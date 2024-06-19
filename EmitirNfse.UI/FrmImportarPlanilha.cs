using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;
using System.Threading;
using System.IO;
using EmitirNfse.Comuns;

namespace EmitirNfse.UI
{
    public partial class FrmImportarPlanilha : Form
    {
        protected int NumeroIdentificacao = 0;
        public FrmImportarPlanilha()
        {
            InitializeComponent();
            lblBarraProgresso.Text = string.Empty;
        }
        OpenFileDialog AbrirArquivo;

        public EventHandler FrmImport_Closing;

        private void FrmImportarPlanilha_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FrmImport_Closing != null)
                FrmImport_Closing(null, null);
        }

        /// <summary>
        /// Obsoleto
        /// </summary>
        /// <param name="Dt"></param>
        private void CriaLoteRps(DataTable Dt)
        {
            //Cursor = Cursors.WaitCursor;
            //Dt.Rows.RemoveAt(0);
            //PbImportacao.Value = 0;
            //PbImportacao.Step = 1;
            //PbImportacao.Maximum = Dt.Rows.Count;
            //int i = 1;
            //foreach (DataRow dr in Dt.Rows)
            //{
            //    lblBarraProgresso.Text = string.Format("{0}/{1}", i, Dt.Rows.Count);
            //    Modelos.EnviarLoteRpsEnvio EnviarLote = new Modelos.EnviarLoteRpsEnvio();
            //    Dados.EmpresaDados Dados = new Dados.EmpresaDados();
            //    string Cnpj = dr["F8"].ToString().Replace(".", "").Replace("/", "").Replace("-", "");
            //    if (Cnpj.Length < 14 && Cnpj.Length > 11)
            //        Cnpj = Cnpj.PadLeft(14, '0');
            //    Modelos.Empresas Empresa = Dados.RetornaEmpresaPorCpfCnpj(Cnpj);
            //    if (Empresa == null)
            //    {
            //        Empresa = new Modelos.Empresas();
            //        Empresa.CNPJ = Cnpj;
            //        Empresa.EnderecoBairro = string.IsNullOrEmpty(dr["F14"].ToString()) == true ? "." : dr["F14"].ToString();
            //        Empresa.EnderecoCEP = dr["F16"].ToString().Replace("-", "");
            //        Empresa.EnderecoCidade = dr["F15"].ToString();
            //        Empresa.EnderecoComplemento = dr["F13"].ToString();
            //        Empresa.EnderecoLog = dr["F11"].ToString();
            //        Empresa.EnderecoNro = string.IsNullOrEmpty(dr["F12"].ToString())== true ? "S/N" : dr["F12"].ToString();
            //        Empresa.EnderecoUF = dr["F17"].ToString();
            //        Empresa.InscrEstadual = string.IsNullOrEmpty(dr["F9"].ToString()) == true ? "Isento" : dr["F9"].ToString().Replace(".", "").Replace("/", "").Replace("-", "");
            //        Empresa.InscrMunicipal = dr["F10"].ToString().Replace(".", "").Replace("/", "").Replace("-", "");
            //        Empresa.RazaoSocial = dr["F6"].ToString();
            //        Empresa.Email = "elza@mcom.com.br";
            //        Empresa.Telefone = "1721371778";
            //        Empresa.CodigoCidade = Dados.PesquisaCep(Empresa.EnderecoCEP) == null ? 0 : Dados.PesquisaCep(Empresa.EnderecoCEP).MUN_NU;
            //        Dados.Salvar(Empresa);
            //    }
            /*Coloca o valor decimal com 2 casas decimais*/
            //string ConverteValorDecimal = Convert.ToDecimal(dr["F4"]).ToString("N2");
            //Modelos.LoteRps Lote = PreencherNotaFiscal(Empresa, Decimal.Parse(ConverteValorDecimal));
            //EnviarLote.LoteRps.Add(Lote);
            //EmitirNfse.Sil.ServicesGinfes.EnviarLoteRps(EnviarLote);
            //    i++;
            //    PbImportacao.PerformStep();
            //    Application.DoEvents();
            //}
            //MessageBox.Show("Importação concluída com êxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //PbImportacao.Value = 0;
            //lblBarraProgresso.Text = string.Empty;
            //Cursor = Cursors.Default;
            //AbrirArquivo.Dispose();
        }

        private Modelos.Rps PreencherNotaFiscal(Modelos.Empresas Empresa, decimal ValorServico)
        {
            Modelos.TomadorServico Tomador = new Modelos.TomadorServico(new Dados.EmpresaDados().RetornaEmpresaPorId(Empresa.EmpresaId));
            Modelos.Rps rps = new Modelos.Rps();
            Modelos.InfRps infrps = new Modelos.InfRps();

            infrps.Servico.Add(new Modelos.DadosServicos()
            {
                Discriminacao = txtObservacao.Text,
                ItemListaServico = "01.07",
                Valores = Comuns.Comuns.CalculaValores(Empresa.CNPJ, ValorServico, 0, 0, 0, false)
            });
            infrps.TomadorServico.Add(Tomador);

            infrps.IdentificacaoRps = new Modelos.IdentificacaoRPS();
            infrps.IdentificacaoRps.Numero = NumeroIdentificacao;
            infrps.IdentificacaoRps.EmpresaId = Empresa.EmpresaId;
            infrps.IdentificacaoRps.status = 0; //Não consultado
            infrps.IdentificacaoRps.Valor = ValorServico;

            infrps.Id = infrps.IdentificacaoRps.Numero;
            infrps.DataEmissao = DateTime.Now.Date.ToString("yyyy-MM-ddTHH:mm:ss");
            infrps.IncentivadorCultural = 2;
            infrps.NaturezaOperacao = 01;
            infrps.OptanteSimplesNacional = 2;
            infrps.RpsSubstituido = null;
            infrps.Status = 1;
            infrps.LoteRpsId = infrps.IdentificacaoRps.Numero;
            infrps.RpsIdentNumero = infrps.IdentificacaoRps.Numero;
            infrps.PrestadorServico.Add(new Modelos.IdentificacaoPrestador());
            rps.infRps.Add(infrps);
            return rps;

        }

        private void btnImportarCadastro_Click(object sender, EventArgs e)
        {
            AbrirArquivo = new OpenFileDialog();
            AbrirArquivo.Filter = "Microsoft Excel (*.xls)| *.xls|Microsoft Excel 2010(*.xlsx) | *.xlsx|CSV(Separado por Vírgulas)(*.csv) | *.csv";
            AbrirArquivo.FilterIndex = 2;
            AbrirArquivo.Title = "Selecione o Arquivo";
            AbrirArquivo.ShowReadOnly = true;
            if (AbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                System.Data.OleDb.OleDbConnection Conexao = new System.Data.OleDb.OleDbConnection(ConfigurationManager.ConnectionStrings["CnnExcel"].ConnectionString.Replace("@Arquivo", AbrirArquivo.FileName));
                System.Data.OleDb.OleDbDataAdapter OleDa = new System.Data.OleDb.OleDbDataAdapter("Select [F4], [F6], [F8], [F9], [F10], [F11], [F12], [F13], [F14], [F15], [F16], [F17] from [Plan1$]", Conexao);
                /* [F4] - Valor a Pagar, 
                 * [F6] - Razão Social,
                 * [F8] - CNPJ,
                 * [F9] - Inscrição Estadual,
                 * [F10] - Inscrição Municipal,
                 * [F11] - Logradouro,
                 * [F12] - Número logradouro,
                 * [F13] - Complemento,
                 * [F14] - Bairro,
                 * [F15] - Cidade,
                 * [F16] - CEP,
                 * [F17] - UF*/
                DataTable dt = new DataTable();
                try
                {
                    Conexao.Open();
                    OleDa.Fill(dt);
                    Conexao.Close();
                    dt.Rows.RemoveAt(0);
                    ImportarCliente(dt);
                    //CriaLoteRps(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AbrirArquivo.Dispose();
                    PbImportacao.Value = 0;
                    lblBarraProgresso.Text = string.Empty;
                    Cursor = Cursors.Default;
                }
            }
        }

        private void ImportarCliente(DataTable Dt)
        {
            Cursor = Cursors.WaitCursor;
            Dt.Rows.RemoveAt(0);
            PbImportacao.Value = 0;
            PbImportacao.Step = 1;
            PbImportacao.Maximum = Dt.Rows.Count;
            int i = 1;
            foreach (DataRow dr in Dt.Rows)
            {
                lblBarraProgresso.Text = string.Format("{0}/{1}", i, Dt.Rows.Count);
                Dados.EmpresaDados Dados = new Dados.EmpresaDados();
                string Cnpj = dr["F8"].ToString().Replace(".", "").Replace("/", "").Replace("-", "");
                if (Cnpj.Length < 14 && Cnpj.Length > 11)
                    Cnpj = Cnpj.PadLeft(14, '0');
                Modelos.Empresas Empresa = Dados.RetornaEmpresaPorCpfCnpj(Cnpj);
                if (Empresa == null)
                {
                    Empresa = new Modelos.Empresas();
                    Empresa.CNPJ = Cnpj;
                    Empresa.EnderecoBairro = string.IsNullOrEmpty(dr["F14"].ToString()) == true ? "." : dr["F14"].ToString();
                    Empresa.EnderecoCEP = dr["F16"].ToString().Replace("-", "");
                    Empresa.EnderecoCidade = dr["F15"].ToString();
                    Empresa.EnderecoComplemento = dr["F13"].ToString();
                    Empresa.EnderecoLog = dr["F11"].ToString();
                    Empresa.EnderecoNro = string.IsNullOrEmpty(dr["F12"].ToString()) == true ? "S/N" : dr["F12"].ToString();
                    Empresa.EnderecoUF = dr["F17"].ToString();
                    Empresa.InscrEstadual = string.IsNullOrEmpty(dr["F9"].ToString()) == true ? "Isento" : dr["F9"].ToString().Replace(".", "").Replace("/", "").Replace("-", "");
                    Empresa.InscrMunicipal = dr["F10"].ToString().Replace(".", "").Replace("/", "").Replace("-", "");
                    Empresa.RazaoSocial = dr["F6"].ToString();
                    Empresa.Email = "elza@mcom.com.br";
                    Empresa.Telefone = "1721371778";
                    Empresa.CodigoCidade = Dados.PesquisaCep(Empresa.EnderecoCEP) == null ? 0 : Dados.PesquisaCep(Empresa.EnderecoCEP).MUN_NU;
                    Dados.Salvar(Empresa);
                }
                i++;
                PbImportacao.PerformStep();
                Application.DoEvents();
            }
            AbrirArquivo.Dispose();
            Dt.AcceptChanges();
            PreencheDgvFaturamento(Dt);
        }

        private void PreencheDgvFaturamento(DataTable DtEmpresas)
        {
            DataTable DtFaturamento = new DataTable();
            DataRow DrFaturamento;
            DtFaturamento.Columns.Add("Empresa");
            DtFaturamento.Columns.Add("CNPJ");
            DtFaturamento.Columns.Add("ValorServico");
            DtFaturamento.Columns.Add("Deduções");
            DtFaturamento.Columns.Add("BaseCalculo");
            DtFaturamento.Columns.Add("Aliquota");
            DtFaturamento.Columns.Add("ValorIss");
            DtFaturamento.Columns.Add("Pis");
            DtFaturamento.Columns.Add("Cofins");
            DtFaturamento.Columns.Add("IR");
            DtFaturamento.Columns.Add("CSLL");
            DtFaturamento.Columns.Add("INSS");
            DtFaturamento.Columns.Add("ValorLiquido");
            DtFaturamento.Columns.Add("Protocolo");
            foreach (DataRow dr in DtEmpresas.Rows)
            {
                string Cnpj = dr["F8"].ToString().Replace(".", "").Replace("/", "").Replace("-", "");
                if (Cnpj.Length < 14 && Cnpj.Length > 11)
                    Cnpj = Cnpj.PadLeft(14, '0');

                DrFaturamento = DtFaturamento.NewRow();
                string ConverteValorDecimal = Convert.ToDecimal(dr["F4"]).ToString("N2");
                Modelos.Valores Valores = Comuns.Comuns.CalculaValores(Cnpj, Decimal.Parse(ConverteValorDecimal), 0, 0, 0, false);
                DrFaturamento["Empresa"] = dr["F6"].ToString();
                DrFaturamento["CNPJ"] = Cnpj;
                DrFaturamento["ValorServico"] = Valores.ValorServicos;
                DrFaturamento["Deduções"] = Valores.ValorDeducoes;
                DrFaturamento["BaseCalculo"] = Valores.BaseCalculo;
                DrFaturamento["Aliquota"] = Valores.Aliquota;
                DrFaturamento["ValorIss"] = Valores.ValorIss;
                DrFaturamento["Pis"] = Valores.ValorPis;
                DrFaturamento["Cofins"] = Valores.ValorCofins;
                DrFaturamento["IR"] = Valores.ValorIr;
                DrFaturamento["CSLL"] = Valores.ValorCsll;
                DrFaturamento["INSS"] = Valores.ValorInss;
                DrFaturamento["ValorLiquido"] = Valores.ValorLiquidoNfse;
                DrFaturamento["Protocolo"] = 0;

                DtFaturamento.Rows.Add(DrFaturamento);
                DtFaturamento.AcceptChanges();
            }

            dgvImportarFaturamento.DataSource = DtFaturamento;
            PbImportacao.Value = 0;
            lblBarraProgresso.Text = string.Empty;
            Cursor = Cursors.Default;
            MessageBox.Show("Importação concluída com êxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelecionarTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvImportarFaturamento.Rows)
            {
                if (dgr.Cells["Selecionar"].ReadOnly == false)
                    dgr.Cells["Selecionar"].Value = true;
            }
        }

        private void btnRemoverSelecao_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgr in dgvImportarFaturamento.Rows)
            {
                dgr.Cells["Selecionar"].Value = false;
            }
        }


        private void btnImportarFaturamento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtObservacao.Text))
            {
                MessageBox.Show("Informe a Observação antes de enviar a Rps", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int i = 0;
                foreach (DataGridViewRow dr in dgvImportarFaturamento.Rows)
                {
                    if (Convert.ToBoolean(dr.Cells["Selecionar"].Value) == true)
                    {
                        i++;
                    }
                }
                pbEnvioRps.Maximum = i;
                FaturarSelecionados();
            }
        }

        private void FaturarSelecionados()
        {
            Dados.EmpresaDados Dados = new Dados.EmpresaDados();
            pbEnvioRps.Step = 1;
            pbEnvioRps.Value = 0;
            Cursor = Cursors.WaitCursor;
            int i = 0;
            Modelos.EnviarLoteRpsEnvio EnviarLote = new Modelos.EnviarLoteRpsEnvio();
            Modelos.LoteRps Lote = new Modelos.LoteRps();
            NumeroIdentificacao = new Dados.RpsDados().RetornaProximoNumeroRps();
            Lote.id = NumeroIdentificacao;
            foreach (DataGridViewRow dgr in dgvImportarFaturamento.Rows)
            {
                lblProgresso.Text = string.Format("Progresso: {0}/{1}", i, pbEnvioRps.Maximum);
                if (Convert.ToBoolean(dgr.Cells["Selecionar"].Value) == true)
                {
                    Modelos.Empresas Empresa = Dados.RetornaEmpresaPorCpfCnpj(dgr.Cells["CNPJ"].Value.ToString());
                    Modelos.Rps Rps = PreencherNotaFiscal(Empresa, Decimal.Parse(dgr.Cells["ValorServico"].Value.ToString()));
                    Lote.ListaRps.Add(Rps);
                    //if ((dgr.Index % 49) == 0 || dgr.Index == (pbEnvioRps.Maximum - 1))
                    //{
                    //    if (dgr.Index > 0)
                    //    {
                            //Se o indice da linha for igual a 50, então será enviado o lote e iniciado outro. 
                            EnviaLoteRps(Lote, EnviarLote);
                            Lote = new Modelos.LoteRps();
                            EnviarLote = new Modelos.EnviarLoteRpsEnvio();
                    //    }
                    //}
                    i++;
                    NumeroIdentificacao++;
                    pbEnvioRps.PerformStep();
                    Application.DoEvents();
                }
            }
            btnRemoverSelecao_Click(this, null);
            Cursor = Cursors.Default;
            pbEnvioRps.Maximum = 0;
            lblProgresso.Text = string.Empty;
            txtObservacao.Clear();
            MessageBox.Show("Importação do faturamento realizada com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EnviaLoteRps(Modelos.LoteRps Lote, Modelos.EnviarLoteRpsEnvio EnviarLote)
        {
            string Retorno = string.Empty;
            try
            {
                Lote.QuantidadeRps = Lote.ListaRps.Count;
                EnviarLote.LoteRps.Add(Lote);
                //Sil.ServicesGinfes.Timeout = 10000;
                Sil.ServicesGinfes.nro = Lote.ListaRps.Count;
                Retorno = Sil.ServicesGinfes.EnviarLoteRps(EnviarLote);
                for (int j = 0; j < Lote.ListaRps.Count; j++)
                {
                    for (int t = 0; t < Lote.ListaRps[j].infRps.Count; t++)
                    {
                        Modelos.IdentificacaoRPS rps = Lote.ListaRps[j].infRps[t].IdentificacaoRps;
                        rps.Protocolo = Retorno;
                        new Dados.RpsDados().SalvarRps(rps);
                    }
                }

                for(int i = 0; i <=pbEnvioRps.Value; i++)
                {

                    if (Convert.ToBoolean(dgvImportarFaturamento.Rows[i].Cells["Selecionar"].Value) == true &&
                        Convert.ToInt32(dgvImportarFaturamento.Rows[i].Cells["Protocolo"].Value) == 0)
                    {
                        dgvImportarFaturamento.Rows[i].Cells["Protocolo"].Value = Retorno;
                        dgvImportarFaturamento.Rows[i].Cells["Selecionar"].ReadOnly = true;
                        dgvImportarFaturamento.Rows[i].Cells["Selecionar"].Value = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                pbEnvioRps.Value = 0;
                lblProgresso.Text = "Progresso:";
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
    }
}
