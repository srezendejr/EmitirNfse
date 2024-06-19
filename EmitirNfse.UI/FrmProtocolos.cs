using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using EmitirNfse.Comuns;
using EmitirNfse.Dados;
using EmitirNfse.Sil;

namespace EmitirNfse.UI
{
    public partial class FrmProtocolos : Form
    {
        public FrmProtocolos()
        {
            InitializeComponent();
            Thread thr = new Thread(new ThreadStart(PreencheListaRpsProtocolos));
            thr.IsBackground = true;
            thr.Start();
        }

        public EventHandler FrmProtocolos_Closing;

        private void FrmProtocolos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FrmProtocolos_Closing != null)
                FrmProtocolos_Closing(null, null);
        }

        private void FrmProtocolos_Load(object sender, EventArgs e)
        {
            //PreencheListaRpsProtocolos();
            cbPesquisa.SelectedIndex = 0;
        }

        private void PreencheListaRpsProtocolos()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(PreencheListaRpsProtocolos));
                return;
            }
            try
            {
                dgvProtocolos.DataSource = new RpsDados().ListarRps();
                //dgvProtocolos.Columns["CNPJ"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        delegate XmlDocument ConsultaLote(int Protocolo);

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvProtocolos.Rows)
            {

                if (Convert.ToBoolean(dgr.Cells["Selecionar"].Value) == true)
                {
                    try
                    {
                        int Protocolo = Convert.ToInt32(dgr.Cells["Protocolo"].Value);
                        ConsultaLote consulta = new ConsultaLote(ServicesGinfes.ConsultaDeLote);
                        consulta.BeginInvoke(Protocolo, ConcluirConsulta, string.Empty);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + dgr.Cells["Protocolo"].Value.ToString(), "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnRemoverSelecao_Click(this, null);
                        break;
                    }
                }
            }
        }

        private void ConcluirConsulta(IAsyncResult result)
        {
            try
            {
                AsyncResult async = (AsyncResult)result;
                ConsultaLote el = (ConsultaLote)async.AsyncDelegate;
                XmlDocument RetornoConsulta = el.EndInvoke(result);
                //RetornoConsulta.Save(@"c:\Temp\Retorno.xml");
                SalvarNfse(RetornoConsulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SalvarNfse(XmlDocument XmlRetornoConsulta)
        {
            List<Modelos.InfNfse> Lstnfse = Comuns.Comuns.PreencheNfse(XmlRetornoConsulta);
            int Protocolo = Comuns.Comuns.RecuperaTextoTagXml(XmlRetornoConsulta, "Protocolo").toInt32();
            IList<Modelos.IdentificacaoRPS> IdenRps = new RpsDados().RetornaRpsPorProtocolo(Protocolo.ToString());


            if (Lstnfse.Count == 0)
            {
                foreach (Modelos.IdentificacaoRPS Rps in IdenRps)
                {

                    Rps.Mensagem = XmlRetornoConsulta.InnerText;
                    Rps.status = 1; // Consultado
                    new RpsDados().ModificarRps(Rps);
                    foreach (DataGridViewRow dgr in dgvProtocolos.Rows)
                    {
                        if (dgr.Cells["Protocolo"].Value.ToString() == Rps.Protocolo)
                        {
                            dgr.Cells["Mensagem"].Value = XmlRetornoConsulta.InnerText;
                        }
                    }
                }
            }
            else
            {
                foreach (Modelos.InfNfse nfse in Lstnfse)
                {
                    foreach (Modelos.IdentificacaoRPS Rps in IdenRps)
                    {
                        if (Rps.Numero == nfse.RpsNumero)
                        {
                            Rps.Mensagem = string.Format("Nota Fiscal com o número {0}", nfse.Numero);
                            Rps.status = 1; // Consultado
                            new RpsDados().ModificarRps(Rps);
                        }
                    }
                    new NfseDados().SalvarNfse(nfse);
                    foreach (DataGridViewRow dgr in dgvProtocolos.Rows)
                    {
                        if (Convert.ToInt32(dgr.Cells["Numero"].Value) == nfse.RpsNumero)
                        //if (Convert.ToBoolean(dgr.Cells["Selecionar"].Value) == true && string.IsNullOrEmpty(dgr.Cells["Mensagem"].Value.ToString()))
                        {
                            dgr.Cells["Mensagem"].Value = string.Format("Nota Fiscal com o número {0}", nfse.Numero.ToString());
                            dgr.Cells["NroNfse"].Value = nfse.Numero.ToString();
                        }
                    }
                }
            }
            //PreencheListaRpsProtocolos();
            btnRemoverSelecao_Click(this, null);
        }

        delegate void CancelarLote(int IdLote);

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvProtocolos.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells["Selecionar"].Value) == true)
                {
                    NfseDados nfseDados = new NfseDados();
                    Modelos.InfNfse Nfse = nfseDados.RetornaNfsePorNro(Convert.ToInt32(dgr.Cells["NroNfse"].Value));
                    RpsDados rpsDados = new RpsDados();
                    if (Nfse.StatusNfse == Convert.ToInt32(Modelos.EnumStatusNfse.Normal))
                    {
                        try
                        {
                            CancelarLote Cancela = new CancelarLote(Sil.ServicesGinfes.CancelarLote);
                            Cancela.BeginInvoke(Convert.ToInt32(dgr.Cells["NroNfse"].Value), ConcluirCancelamento, string.Empty);
                            Modelos.IdentificacaoRPS Rps = rpsDados.RetornaRpsPorNumero(Nfse.RpsNumero);
                            Rps.Mensagem = string.Format("Cancelamento da nota fiscal efetuado em {0}", DateTime.Now);
                            rpsDados.ModificarRps(Rps);
                            Nfse.StatusNfse = Convert.ToInt32(Modelos.EnumStatusNfse.Cancelada);
                            nfseDados.SalvarNfse(Nfse);
                            dgr.Cells["Mensagem"].Value = Rps.Mensagem;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show(string.Format("A NFSE {0} não pode ser cancelada pois foi cancelada ou substituída", dgr.Cells["NroNfse"].Value), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                }
            }
        }

        private void ConcluirCancelamento(IAsyncResult result)
        {
            AsyncResult async = (AsyncResult)result;
            CancelarLote el = (CancelarLote)async.AsyncDelegate;
            el.EndInvoke(result);
            btnRemoverSelecao_Click(this, null);
        }

        private void btnSubstituir_Click(object sender, EventArgs e)
        {
            int i = 0;
            int NumeroNfse = 0;
            int NumeroRps = 0;
            int IdEmpresa = 0;
            foreach (DataGridViewRow dgr in dgvProtocolos.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells["Selecionar"].Value) == true)
                {
                    NumeroNfse = Convert.ToInt32(dgr.Cells["NroNfse"].Value);
                    NumeroRps = Convert.ToInt32(dgr.Cells["Numero"].Value);
                    IdEmpresa = new EmpresaDados().RetornaEmpresaPorCpfCnpj(dgr.Cells["Cnpj"].Value.ToString()).EmpresaId;
                    i++;
                }
            }
            if (i == 1)
            {
                RpsDados rpsDados = new RpsDados();
                NfseDados nfseDados = new NfseDados();
                Modelos.InfNfse Nfse = nfseDados.RetornaNfsePorNro(NumeroNfse);
                if (Nfse.StatusNfse == Convert.ToInt32(Modelos.EnumStatusNfse.Normal) || Nfse == null)
                {
                    Modelos.IdentificacaoRPS Rps = rpsDados.RetornaRpsPorNumero(NumeroRps);
                    FrmEmitirNfse frm = new FrmEmitirNfse();
                    int NroSubRps = 0;
                    frm.EmitirRpsSubstituto(Rps.Tipo, Rps.Numero, Rps.Serie, IdEmpresa, out NroSubRps);
                    if (NroSubRps > 0)
                    {
                        Rps.Mensagem = String.Format("Este Rps foi substituído pelo Rps Número: {0}", NroSubRps);
                        rpsDados.ModificarRps(Rps);
                        Nfse.StatusNfse = Convert.ToInt32(Modelos.EnumStatusNfse.Substituida);
                        nfseDados.SalvarNfse(Nfse);
                    }
                    PreencheListaRpsProtocolos();
                }
                else
                {
                    MessageBox.Show("Este RPS não pode ser substituído pois foi cancelado ou substituído", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecione apenas 1 NFSE para substituir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelecionarTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvProtocolos.Rows)
            {
                dgr.Cells["Selecionar"].Value = true;
            }
        }

        private void btnRemoverSelecao_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvProtocolos.Rows)
            {
                dgr.Cells["Selecionar"].Value = false;
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPesquisa.Text))
            {
                DataTable dt = (DataTable)dgvProtocolos.DataSource;
                dgvProtocolos.DataSource = null;
                string OpcaoPesquisa = cbPesquisa.SelectedItem.ToString();
                DataView dv = new DataView(dt.Copy());
                string FiltroExpressao = string.Empty;
                switch (OpcaoPesquisa)
                {
                    case "Razão Social":
                        FiltroExpressao = string.Format("RazaoSocial like '%{0}%'", txtPesquisa.Text);
                        break;
                    case "CNPJ":
                        FiltroExpressao = string.Format("CNPJ like '%{0}%' ", txtPesquisa.Text);
                        break;
                    case "Número Nfse":
                        FiltroExpressao = string.Format("NroNfse = {0}", txtPesquisa.Text);
                        break;
                    case "Protocolo":
                        FiltroExpressao = string.Format("Protocolo = {0}", txtPesquisa.Text);
                        break;
                }
                dv.RowFilter = FiltroExpressao;
                dgvProtocolos.DataSource = dv.ToTable();
                lnkLabel.Visible = true;
            }
            else
            {
                MessageBox.Show("Informe os dados da pesquisa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PreencheListaRpsProtocolos();
            lnkLabel.Visible = false;
            txtPesquisa.Clear();
        }

        private void chkSemRetorno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSemRetorno.Checked)
            {
                DataTable dt = (DataTable)dgvProtocolos.DataSource;
                dgvProtocolos.DataSource = null;
                DataView dv = new DataView(dt.Copy());
                dv.RowFilter = "Mensagem is null";
                dgvProtocolos.DataSource = dv.ToTable();
            }
            else
            {
                PreencheListaRpsProtocolos();
            }
        }
    }
}
