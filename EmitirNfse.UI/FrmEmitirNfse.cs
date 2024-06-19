using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EmitirNfse.Dados;
using EmitirNfse.Sil;
using System.Drawing;

namespace EmitirNfse.UI
{
    public partial class FrmEmitirNfse : Form
    {
        delegate string enviarlote(Modelos.EnviarLoteRpsEnvio objeto);
        protected Modelos.IdentificacaoRPS RpsSubstituto = null;
        protected Modelos.IdentificacaoRPS RpsOperacao = new Modelos.IdentificacaoRPS();
        protected int IdEmpresa = 0;
        protected int NovoNrorps;
        private ToolTip ToolTipCliente = new ToolTip();
        public void EmitirRpsSubstituto(int tipo, int nro, string serie, int EmpresaId, out int NovoRps)
        {
            RpsSubstituto = new Modelos.IdentificacaoRPS();
            RpsSubstituto.Tipo = tipo;
            RpsSubstituto.Serie = serie;
            RpsSubstituto.Numero = nro;
            IdEmpresa = EmpresaId;
            this.Text = string.Format("Subistituição do Rps Número {0}", nro);
            this.ShowDialog();
            NovoRps = NovoNrorps;
        }

        public FrmEmitirNfse()
        {
            InitializeComponent();
            InicializaCamposFormulario();
            ToolTipCliente.SetToolTip(txtBaseCalculo, "Base de Cálculo dos impostos");
        }

        private void InicializaCamposFormulario()
        {
            foreach (Control ctrl in grpbxValores.Controls)
            {
                if (ctrl is TextBox) ctrl.Text = "0";
            }
            foreach (Control ctrl in grpbxIssRetido.Controls)
            {
                if (ctrl is TextBox) ctrl.Text = "0";
            }
            foreach (Control ctrl in grpbxImpostosFederais.Controls)
            {
                if (ctrl is TextBox) ctrl.Text = "0";
            }
            foreach (Control ctrl in grpbxTotalizador.Controls)
            {
                if (ctrl is TextBox) ctrl.Text = "0";
            }
        }

        private void FrmEmitirNfse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void FrmEmitirNfse_Load(object sender, EventArgs e)
        {
            PreencheComboBoxServico();
            lblDataEmissao.Text = string.Format("Data Emissão: {0}", DateTime.Now.ToShortDateString());
            PreencheComboEmpresa();
            PreencheComboNatOperacao();
            this.cboCliente.DrawMode = DrawMode.OwnerDrawFixed;
            ToolTipCliente = new ToolTip();
            if (IdEmpresa != 0)
            {
                cboCliente.SelectedValue = IdEmpresa;
                cboCliente.Enabled = false;
            }
        }

        private void PreencheComboEmpresa()
        {
            try
            {
                IList<Modelos.Empresas> LstEmpresa = new EmpresaDados().ListarEmpresas();
                LstEmpresa.Insert(0, new Modelos.Empresas() { EmpresaId = 0, RazaoSocial = "Selecione" });
                cboCliente.DataSource = LstEmpresa;
                cboCliente.DisplayMember = "RazaoSocial";
                cboCliente.ValueMember = "EmpresaId";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void PreencheComboBoxServico()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CodigoServico");
            dt.Columns.Add("DescricaoServico");
            DataRow dr = dt.NewRow();
            dr["CodigoServico"] = "0";
            dr["DescricaoServico"] = "Selecione";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr["CodigoServico"] = "01.07";
            dr["DescricaoServico"] = "01.07.00";
                /*"Suporte técnico em informática,inclusive instalação, configuração e manutenção de programas de computação e bancos de dados.";*/
            dt.Rows.Add(dr);
            cboServico.DataSource = dt;
            cboServico.DisplayMember = "DescricaoServico";
            cboServico.ValueMember = "CodigoServico";
        }

        private void PreencheComboNatOperacao()
        {
            Array arrEnum = Enum.GetValues(typeof(Modelos.EnumNatOperacao));
            ArrayList lst = new ArrayList();
            foreach (Enum a in arrEnum)
            {
                lst.Add(new KeyValuePair<int, string>(Convert.ToInt32(a), ObterDescricao(a)));
            }
            cboNaturezaOperacao.DataSource = lst;
            cboNaturezaOperacao.DisplayMember = "Value";
            cboNaturezaOperacao.ValueMember = "Key";
        }

        private string ObterDescricao(Enum Valor)
        {
            FieldInfo fi = Valor.GetType().GetField(Valor.ToString());
            DescriptionAttribute[] atributos = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return atributos.Length > 0 ? atributos[0].Description ?? "Nulo" : Valor.ToString();
        }

        private void txtValorServico_Leave(object sender, EventArgs e)
        {
            if (this.EhNumerico(txtValorServico.Text))
            {
                CalculaValorImpostos();
            }
        }

        private bool EhNumerico(string Expressao)
        {
            Regex rg = new Regex(@"[0-9,-\.]+$");
            return rg.IsMatch(Expressao);
        }

        private void CalculaValorImpostos()
        {
            Modelos.Valores Valor = Comuns.Comuns.CalculaValores(new EmpresaDados().RetornaEmpresaPorId(Convert.ToInt32(cboCliente.SelectedValue)).CNPJ,
                decimal.Parse(txtValorServico.Text), decimal.Parse(txtOutrasRetencoes.Text), decimal.Parse(txtDescontoIncondicionado.Text),
                decimal.Parse(txtDescontoCondicionado.Text), chkIssRetido.Checked);
            txtValorDeducoes.Text = Valor.ValorDeducoes.ToString("N2");
            txtOutrasRetencoes.Text = Valor.OutrasRetencoes.ToString("N2");
            txtDescontoCondicionado.Text = Valor.DescontoCondicionado.ToString("N2");
            txtDescontoIncondicionado.Text = Valor.DescontoIncondicionado.ToString("N2");
            txtValorIssRetido.Text = Valor.ValorIssRetido.ToString("N2");
            txtValorPis.Text = Valor.ValorPis.ToString("N2");
            txtValorCofins.Text = Valor.ValorCofins.ToString("N2");
            txtValorIr.Text = Valor.ValorIr.ToString("N2");
            txtValorInss.Text = Valor.ValorInss.ToString("N2");
            txtValorCsll.Text = Valor.ValorCsll.ToString("N2");
            txtBaseCalculo.Text = Valor.BaseCalculo.ToString("N2");
            txtValorLiquido.Text = Valor.ValorLiquidoNfse.ToString("N2");
            txtValorIss.Text = Valor.ValorIss.ToString("N2");            
            
            //Decimal ValorAcumuladoServico = new Dados.RpsDados().RetornaTotalRpsAcumulado(Convert.ToInt32(cboCliente.SelectedValue));
            //Decimal ValorServico = Decimal.Parse(txtValorServico.Text);
            //Decimal ValorBaseCalculoReduzida = (ValorServico * 0.33M);
            //txtBaseCalculo.Text = (ValorServico - ValorBaseCalculoReduzida).ToString("N2");
            //txtValorDeducoes.Text = ValorBaseCalculoReduzida.ToString("N2");
            //txtValorIss.Text = (Decimal.Parse(txtBaseCalculo.Text) * (Convert.ToDecimal(ConfigurationManager.AppSettings["Iss"]) / 100M)).ToString("N2");
            //if (ValorServico >= 5000M || ValorAcumuladoServico >=5000M)
            //{
            //    txtValorCofins.Text = (ValorServico * (Convert.ToDecimal(ConfigurationManager.AppSettings["Cofins"]) / 100)).ToString("N2");
            //    txtValorCsll.Text = (ValorServico * (Convert.ToDecimal(ConfigurationManager.AppSettings["Csll"]) / 100)).ToString("N2");
            //    txtValorPis.Text = (ValorServico * (Convert.ToDecimal(ConfigurationManager.AppSettings["Pis"]) / 100)).ToString("N2");
            //}
            //if (ValorServico >= 650M)
            //{
            //    txtValorIr.Text = (ValorServico * (Convert.ToDecimal(ConfigurationManager.AppSettings["IR"]) / 100)).ToString("N2");
            //}

            //if (chkIssRetido.Checked)
            //{
            //    txtValorIssRetido.Text = (Decimal.Parse(txtBaseCalculo.Text) * (Convert.ToDecimal(ConfigurationManager.AppSettings["Iss"]) / 100M)).ToString("N2");
            //    txtValorIss.Text = "0";
            //}
            //else
            //    txtValorIssRetido.Text = "0";

            //txtValorLiquido.Text = (ValorServico - (Decimal.Parse(txtValorPis.Text) + Decimal.Parse(txtValorCofins.Text) + Decimal.Parse(txtValorCsll.Text)
            //        + Decimal.Parse(txtValorInss.Text) + Decimal.Parse(txtValorIr.Text) + Decimal.Parse(txtOutrasRetencoes.Text) + Decimal.Parse(txtValorIssRetido.Text)
            //        + Decimal.Parse(txtDescontoIncondicionado.Text) + Decimal.Parse(txtDescontoCondicionado.Text))).ToString("N2");
        }

        private void chkIssRetido_CheckedChanged(object sender, EventArgs e)
        {
            if (this.EhNumerico(txtValorServico.Text))
            {
                CalculaValorImpostos();
            }
        }

        private void txtValorDeducoes_Leave(object sender, EventArgs e)
        {
            txtValorServico_Leave(this, e);

        }

        private void txtOutrasRetencoes_Leave(object sender, EventArgs e)
        {
            txtValorServico_Leave(this, e);
        }

        private void txtDescontoIncondicionado_Leave(object sender, EventArgs e)
        {
            txtValorServico_Leave(this, e);

        }

        private void txtDescontoCondicionado_Leave(object sender, EventArgs e)
        {
            txtValorServico_Leave(this, e);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                Modelos.EnviarLoteRpsEnvio EnviarLote = new Modelos.EnviarLoteRpsEnvio();
                Modelos.LoteRps Lote = new Modelos.LoteRps();
                Modelos.TomadorServico Tomador = new Modelos.TomadorServico(new EmpresaDados().RetornaEmpresaPorId(Convert.ToInt32(cboCliente.SelectedValue)));
                Modelos.Rps rps = new Modelos.Rps();
                Modelos.InfRps infrps = new Modelos.InfRps();

                infrps.Servico.Add(PreencheServico());
                infrps.TomadorServico.Add(Tomador);

                infrps.IdentificacaoRps = new Modelos.IdentificacaoRPS();
                infrps.IdentificacaoRps.Numero = new RpsDados().RetornaProximoNumeroRps();
                infrps.IdentificacaoRps.EmpresaId = Convert.ToInt32(cboCliente.SelectedValue);
                infrps.IdentificacaoRps.status = 0; //Não consultado
                infrps.IdentificacaoRps.Valor = Convert.ToDecimal(txtValorServico.Text);

                
                infrps.Id = infrps.IdentificacaoRps.Numero;
                infrps.DataEmissao = DateTime.Now.Date.ToString("yyyy-MM-ddTHH:mm:ss");
                infrps.IncentivadorCultural = 2;
                infrps.NaturezaOperacao = Convert.ToInt32(cboNaturezaOperacao.SelectedValue);
                infrps.OptanteSimplesNacional = 2;
                infrps.RpsSubstituido = RpsSubstituto;
                infrps.Status = 1;
                infrps.RpsIdentNumero = infrps.IdentificacaoRps.Numero;
                infrps.PrestadorServico.Add(new Modelos.IdentificacaoPrestador());

                rps.infRps.Add(infrps);
                Lote.ListaRps.Add(rps);
                Lote.QuantidadeRps = Lote.ListaRps.Count;
                EnviarLote.LoteRps.Add(Lote);
                RpsOperacao = infrps.IdentificacaoRps;

                enviarlote el = new enviarlote(ServicesGinfes.EnviarLoteRps);
                el.BeginInvoke(EnviarLote, new AsyncCallback(ConcluirEnvio), string.Empty);
                if (RpsSubstituto != null)
                {
                    NovoNrorps = infrps.IdentificacaoRps.Numero;
                    this.Dispose();
                }
                LimparCampos();

            }
            
        }

        private void LimparCampos()
        {
            cboCliente.SelectedIndex = 0;
            cboServico.SelectedIndex = 0;
            txtObservacao.Clear();
            foreach (Control ctrl in grpbxValores.Controls)
            {
                if (ctrl is TextBox) ((TextBox)ctrl).Text = "0";
            }
            foreach (Control ctrl in grpbxImpostosFederais.Controls)
            {
                if (ctrl is TextBox) ((TextBox)ctrl).Text = "0";
            }
            foreach (Control ctrl in grpbxIssRetido.Controls)
            {
                if (ctrl is TextBox) ((TextBox)ctrl).Text = "0";
                if (ctrl is CheckBox) ((CheckBox)ctrl).Checked = false;
            }
            foreach (Control ctrl in grpbxTotalizador.Controls)
            {
                if (ctrl is TextBox) ((TextBox)ctrl).Text = "0";
            }
            cboCliente.Focus();
        }

        private void ConcluirEnvio(IAsyncResult result)
        {
            try
            {
                AsyncResult async = (AsyncResult)result;
                enviarlote el = (enviarlote)async.AsyncDelegate;
                string Retorno = el.EndInvoke(result);
                if (!string.IsNullOrEmpty(Retorno))
                {
                    if (Retorno.Contains("Erro"))
                        MessageBox.Show("Ocorreu um erro na integração da Nfse. Veja mensagem a seguir:\r\n" + Retorno, "Falha na Integração", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                    {
                        RpsOperacao.Protocolo = Retorno;
                        new RpsDados().SalvarRps(RpsOperacao);
                        MessageBox.Show(string.Format("RPS enviado com sucesso. Número do protocolo de entrega: {0}", Retorno), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaDados()
        {
            bool Validacao = true;
            StringBuilder SbMensagem = new StringBuilder();

            if (cboCliente.SelectedIndex == 0)
            {
                Validacao = false;
                SbMensagem.AppendLine("Informe o tomador do serviço");
            }

            if (cboServico.SelectedIndex == 0)
            {
                Validacao = false;
                SbMensagem.AppendLine("Informe o serviço");
            }

            if(txtValorServico.Text == "0" || string.IsNullOrEmpty(txtValorServico.Text))
            {
                Validacao = false;
                SbMensagem.AppendLine("Informe o valor do serviço");
            }

            if (Decimal.Parse(txtBaseCalculo.Text) > Decimal.Parse(txtValorLiquido.Text))
            {
                Validacao = false;
                SbMensagem.AppendLine("O valor da Base de Cálculo está incorreto");
            }

            if (string.IsNullOrEmpty(txtObservacao.Text))
            {
                Validacao = false;
                SbMensagem.AppendLine("Informe o texto de observação da Nota Fiscal");
            }

            if (!Validacao)
                MessageBox.Show(SbMensagem.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return Validacao;
        }

        private Modelos.DadosServicos PreencheServico()
        {
            Modelos.DadosServicos DadosServico = new Modelos.DadosServicos();
            DadosServico.Discriminacao = txtObservacao.Text;
            DadosServico.ItemListaServico = cboServico.SelectedValue.ToString();
            //DadosServico.Valores = PreencheValoresServico();
            DadosServico.Valores = Comuns.Comuns.CalculaValores(new EmpresaDados().RetornaEmpresaPorId(Convert.ToInt32(cboCliente.SelectedValue)).CNPJ,
                decimal.Parse(txtValorServico.Text), decimal.Parse(txtOutrasRetencoes.Text), decimal.Parse(txtDescontoIncondicionado.Text),
                decimal.Parse(txtDescontoCondicionado.Text), chkIssRetido.Checked);


            return DadosServico;
        }

        //private Modelos.Valores PreencheValoresServico()
        //{
        //    Modelos.Valores ValoresServico = new Modelos.Valores();

        //    ValoresServico.Aliquota = Decimal.Parse(ConfigurationManager.AppSettings["ISS"]) / 100M;
        //    ValoresServico.BaseCalculo = Decimal.Parse(txtBaseCalculo.Text);
        //    ValoresServico.DescontoCondicionado = Decimal.Parse(txtDescontoCondicionado.Text);
        //    ValoresServico.DescontoIncondicionado = Decimal.Parse(txtDescontoIncondicionado.Text);
        //    ValoresServico.IssRetido = chkIssRetido.Checked == true ? 1 : 2;
        //    ValoresServico.OutrasRetencoes = Decimal.Parse(txtOutrasRetencoes.Text);
        //    ValoresServico.ValorCofins = Decimal.Parse(txtValorCofins.Text);
        //    ValoresServico.ValorCsll = Decimal.Parse(txtValorCsll.Text);
        //    ValoresServico.ValorDeducoes = Decimal.Parse(txtValorDeducoes.Text);
        //    ValoresServico.ValorInss = Decimal.Parse(txtValorInss.Text);
        //    ValoresServico.ValorIr = Decimal.Parse(txtValorIr.Text);
        //    ValoresServico.ValorIss = Decimal.Parse(txtValorIss.Text);
        //    ValoresServico.ValorIssRetido = Decimal.Parse(txtValorIssRetido.Text);
        //    ValoresServico.ValorLiquidoNfse = Decimal.Parse(txtValorLiquido.Text);
        //    ValoresServico.ValorPis = Decimal.Parse(txtValorPis.Text);
        //    ValoresServico.ValorServicos = Decimal.Parse(txtValorServico.Text);

        //    return ValoresServico;
        //}


        private void btnCadastraTomador_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.frmCliente_Closing += new EventHandler(AtualizaComboCliente);
            frm.AbrirForm();
        }

        private void AtualizaComboCliente(object sender, EventArgs e)
        {
            PreencheComboEmpresa();
        }

        public EventHandler frmNotaFiscal_Closing;
        private void FrmEmitirNfse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmNotaFiscal_Closing != null)
                frmNotaFiscal_Closing(null, null);
        }

        private void cboCliente_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;
            
            //Define o texto do item "selecionado"
            string text = this.cboCliente.GetItemText(cboCliente.Items[e.Index]);
            e.DrawBackground();
            //Define a cor de preenchimento dos itens
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(text, e.Font, br, e.Bounds);
            }

            //Verifica pra qual item o ponteiro do mouse está apontado. Assim é exibido o tooltipo do item "selecionado".
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                if (e.Index > 0)
                    this.ToolTipCliente.Show(text, this, e.Bounds.Right, e.Bounds.Bottom);
                else
                    this.ToolTipCliente.Hide(this);
            }

            e.DrawFocusRectangle();
        }
    }
}
