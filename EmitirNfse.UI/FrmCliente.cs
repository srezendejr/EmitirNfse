using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EmitirNfse.Dados;

namespace EmitirNfse.UI
{
    public partial class FrmCliente : Form
    {
        private int IdEmpresa;
        private ToolTip ttp;
        private int CodigoMunicipio = 0;
        public FrmCliente()
        {
            InitializeComponent();
            ttp = new ToolTip();
            ttp.SetToolTip(mtxtCep, "Informe o Cep e clique no botão Pesquisa Cep para preencher o Endereço");
            ttp.SetToolTip(btnCep, "Pesquisa Cep");
        }

        public void AbrirForm()
        {
            this.Show();
            this.btnNovo_Click(this, null);
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
            cboTipo.Focus();
            cbPesquisa.SelectedIndex = 0;
            try
            {
                PreencheComboUf();
                RetornaClientes();
                BindingControles();
                PreencheComboCidade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RetornaClientes()
        {
            try
            {
                dgvClientes.DataSource = new EmpresaDados().ListarEmpresas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BindingControles()
        {
            mtxtCpfCnpj.DataBindings.Add("Text", dgvClientes.DataSource, "CNPJ");
            txtNomeRazaoSocial.DataBindings.Add("Text", dgvClientes.DataSource, "RazaoSocial");
            txtInscMunicipal.DataBindings.Add("Text", dgvClientes.DataSource, "InscrMunicipal");
            txtInscEstadual.DataBindings.Add("Text", dgvClientes.DataSource, "InscrEstadual");
            mtxtCep.DataBindings.Add("Text", dgvClientes.DataSource, "EnderecoCEP");
            cboCidade.DataBindings.Add("SelectedItem", dgvClientes.DataSource, "EnderecoCidade");
            cboUf.DataBindings.Add("SelectedItem", dgvClientes.DataSource, "EnderecoUF");
            txtLogradrouro.DataBindings.Add("Text", dgvClientes.DataSource, "EnderecoLog");
            txtNumeroLog.DataBindings.Add("Text", dgvClientes.DataSource, "EnderecoNro");
            txtComplemento.DataBindings.Add("Text", dgvClientes.DataSource, "EnderecoComplemento");
            txtBairro.DataBindings.Add("Text", dgvClientes.DataSource, "EnderecoBairro");
            txtContato.DataBindings.Add("Text", dgvClientes.DataSource, "NomeResponsavel");
            mtxtTelefone.DataBindings.Add("Text", dgvClientes.DataSource, "Telefone");
            txtEmail.DataBindings.Add("Text", dgvClientes.DataSource, "Email");
        }

        private void PreencheComboUf()
        {
            BindingList<string> BdgLst = new BindingList<string>(new EmpresaDados().RetornaUf());
            cboUf.DataSource = BdgLst;
        }

        private void PreencheComboCidade()
        {
            BindingList<string> BdgLst = new BindingList<string>(new EmpresaDados().RetornaCidadePorUf(cboUf.SelectedItem.ToString()));
            cboCidade.DataSource = BdgLst;
        }

        private void cboTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = cboTipo.SelectedIndex;
            switch (index)
            {
                case 0:
                    lblNomeRazaoSocial.Text = "Razão Social:";
                    lblCpfCnpj.Text = "Cnpj:";
                    mtxtCpfCnpj.Mask = "00.000.000/0000-00";
                    break;
                case 1:
                    lblNomeRazaoSocial.Text = "Nome:";
                    lblCpfCnpj.Text = "Cpf:";
                    mtxtCpfCnpj.Mask = "000,000,000-00";
                    break;

            }
        }

        private void btnCep_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtxtCep.Text))
            {
                Modelos.Cep cep = new EmpresaDados().PesquisaCep(mtxtCep.Text);
                txtBairro.Text = cep.BAI_NO;
                txtLogradrouro.Text = cep.LOG_NO_ABREV;
                cboUf.SelectedItem = cep.UFE_SG;
                PreencheComboCidade();
                cboCidade.SelectedItem = cep.LOC_NO;
                CodigoMunicipio = cep.MUN_NU;
                txtNumeroLog.Focus();
            }
            else
            {
                MessageBox.Show("Informe o Cep", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void cboUf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PreencheComboCidade();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                try
                {
                    Modelos.Empresas empresa = PreencheEmpresa();
                    empresa.EmpresaId = IdEmpresa;
                    new EmpresaDados().Salvar(empresa);
                    RetornaClientes();
                    //btnNovo_Click(this, null);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        private Modelos.Empresas PreencheEmpresa()
        {
            Modelos.Empresas Empresa = new Modelos.Empresas();
            Empresa.CNPJ = mtxtCpfCnpj.Text;
            Empresa.RazaoSocial = txtNomeRazaoSocial.Text;
            Empresa.InscrEstadual = txtInscEstadual.Text;
            Empresa.EnderecoCEP = mtxtCep.Text;
            Empresa.EnderecoUF = cboUf.SelectedItem.ToString();
            Empresa.EnderecoCidade = cboCidade.SelectedItem.ToString();
            Empresa.EnderecoLog = txtLogradrouro.Text;
            Empresa.EnderecoNro = txtNumeroLog.Text;
            Empresa.EnderecoComplemento = txtComplemento.Text;
            Empresa.EnderecoBairro = txtBairro.Text;
            Empresa.NomeResponsavel = txtContato.Text;
            Empresa.Email = txtEmail.Text;
            Empresa.Telefone = mtxtTelefone.Text;
            Empresa.InscrMunicipal = txtInscMunicipal.Text;
            Empresa.CodigoCidade = CodigoMunicipio;

            return Empresa;
        }

        private bool ValidaDados()
        {
            bool Validacao = true;
            StringBuilder SbMensagem = new StringBuilder();
            if (string.IsNullOrEmpty(txtNomeRazaoSocial.Text))
            {
                Validacao = false;
                SbMensagem.AppendLine("Informe Nome/Razão Social");
            }

            if (string.IsNullOrEmpty(mtxtCpfCnpj.Text))
            {
                Validacao = false;
                SbMensagem.AppendLine("Informe o Cpf/Cnpj");
            }

            if (string.IsNullOrEmpty(txtLogradrouro.Text))
            {
                Validacao = false;
                SbMensagem.AppendLine("Informe o endereço");
            }

            if (string.IsNullOrEmpty(txtContato.Text))
            {
                Validacao = false;
                SbMensagem.AppendLine("Informe o contato");
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Validacao = false;
                SbMensagem.AppendLine("Informe o Email");
            }

            if (!Comuns.Comuns.ValidaCpfCnpj(mtxtCpfCnpj.Text))
            {
                Validacao = false;
                SbMensagem.AppendLine("Cpf/Cnpj Inválido. Informe um valor válido");
            }
            if (!Validacao)
                MessageBox.Show(SbMensagem.ToString(), "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return Validacao;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            IdEmpresa = 0;
            foreach (Control ctrl in pnlClientes.Controls)
            {
                if (ctrl is TextBox) ((TextBox)ctrl).Clear();
                if (ctrl is ComboBox) ((ComboBox)ctrl).SelectedIndex = 0;
                if (ctrl is MaskedTextBox) ((MaskedTextBox)ctrl).Clear();
                PreencheComboCidade();
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                    IdEmpresa = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["EmpresaId"].Value);
                    cboTipo.SelectedIndex = mtxtCpfCnpj.Text.Count() == 14 ? 0 : 1;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public EventHandler frmCliente_Closing;

        private void FrmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmCliente_Closing != null)
                frmCliente_Closing(null, null);
        }

        private void cboUf_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            PreencheComboCidade();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            List<Modelos.Empresas> LstClientes = (List<Modelos.Empresas>)dgvClientes.DataSource;
            dgvClientes.DataSource = null;
            List<Modelos.Empresas> Resultado = new List<Modelos.Empresas>();
            switch (cbPesquisa.SelectedItem.ToString())
            {
                case "Razão Social":
                    foreach (var i in LstClientes)
                    {
                        if (i.RazaoSocial.ToUpper().Contains(txtPesquisa.Text.ToUpper()))
                            Resultado.Add(i);
                    }
                    break;
                case "CNPJ":
                    foreach (var i in LstClientes)
                    {
                        if (i.CNPJ.Contains(txtPesquisa.Text))
                        {
                            Resultado.Add(i);
                        }
                    }
                    break;
            }
            dgvClientes.DataSource = Resultado;
            lnkLabel.Visible = true;
        }

        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RetornaClientes();
            lnkLabel.Visible = false;
            txtPesquisa.Clear();
        }



    }
}
