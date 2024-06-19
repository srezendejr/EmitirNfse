namespace EmitirNfse.UI
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.lnkLabel = new System.Windows.Forms.LinkLabel();
            this.lblNumeroLog = new System.Windows.Forms.Label();
            this.txtInscMunicipal = new System.Windows.Forms.TextBox();
            this.lblInscMunicipal = new System.Windows.Forms.Label();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.lblInscEstadual = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneContato = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cboUf = new System.Windows.Forms.ComboBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumeroLog = new System.Windows.Forms.TextBox();
            this.txtLogradrouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.btnCep = new System.Windows.Forms.Button();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.mtxtCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.txtNomeRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblNomeRazaoSocial = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(0, 38);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(666, 200);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.VirtualMode = true;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // pnlClientes
            // 
            this.pnlClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClientes.Controls.Add(this.lnkLabel);
            this.pnlClientes.Controls.Add(this.lblNumeroLog);
            this.pnlClientes.Controls.Add(this.txtInscMunicipal);
            this.pnlClientes.Controls.Add(this.lblInscMunicipal);
            this.pnlClientes.Controls.Add(this.txtInscEstadual);
            this.pnlClientes.Controls.Add(this.lblInscEstadual);
            this.pnlClientes.Controls.Add(this.txtEmail);
            this.pnlClientes.Controls.Add(this.lblEmail);
            this.pnlClientes.Controls.Add(this.mtxtTelefone);
            this.pnlClientes.Controls.Add(this.lblTelefoneContato);
            this.pnlClientes.Controls.Add(this.txtContato);
            this.pnlClientes.Controls.Add(this.lblContato);
            this.pnlClientes.Controls.Add(this.cboCidade);
            this.pnlClientes.Controls.Add(this.lblCidade);
            this.pnlClientes.Controls.Add(this.cboUf);
            this.pnlClientes.Controls.Add(this.lblUf);
            this.pnlClientes.Controls.Add(this.txtBairro);
            this.pnlClientes.Controls.Add(this.lblBairro);
            this.pnlClientes.Controls.Add(this.txtComplemento);
            this.pnlClientes.Controls.Add(this.lblComplemento);
            this.pnlClientes.Controls.Add(this.txtNumeroLog);
            this.pnlClientes.Controls.Add(this.txtLogradrouro);
            this.pnlClientes.Controls.Add(this.lblLogradouro);
            this.pnlClientes.Controls.Add(this.btnCep);
            this.pnlClientes.Controls.Add(this.mtxtCep);
            this.pnlClientes.Controls.Add(this.lblCep);
            this.pnlClientes.Controls.Add(this.mtxtCpfCnpj);
            this.pnlClientes.Controls.Add(this.lblCpfCnpj);
            this.pnlClientes.Controls.Add(this.cboTipo);
            this.pnlClientes.Controls.Add(this.lblTipoPessoa);
            this.pnlClientes.Controls.Add(this.txtNomeRazaoSocial);
            this.pnlClientes.Controls.Add(this.lblNomeRazaoSocial);
            this.pnlClientes.Location = new System.Drawing.Point(0, 238);
            this.pnlClientes.MinimumSize = new System.Drawing.Size(666, 336);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(666, 339);
            this.pnlClientes.TabIndex = 1;
            // 
            // lnkLabel
            // 
            this.lnkLabel.AutoSize = true;
            this.lnkLabel.Location = new System.Drawing.Point(530, 308);
            this.lnkLabel.Name = "lnkLabel";
            this.lnkLabel.Size = new System.Drawing.Size(119, 19);
            this.lnkLabel.TabIndex = 68;
            this.lnkLabel.TabStop = true;
            this.lnkLabel.Text = "Desfazer Pesquisa";
            this.lnkLabel.Visible = false;
            this.lnkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabel_LinkClicked);
            // 
            // lblNumeroLog
            // 
            this.lblNumeroLog.AutoSize = true;
            this.lblNumeroLog.Location = new System.Drawing.Point(460, 142);
            this.lblNumeroLog.Name = "lblNumeroLog";
            this.lblNumeroLog.Size = new System.Drawing.Size(62, 19);
            this.lblNumeroLog.TabIndex = 50;
            this.lblNumeroLog.Text = "Número:";
            // 
            // txtInscMunicipal
            // 
            this.txtInscMunicipal.Location = new System.Drawing.Point(536, 18);
            this.txtInscMunicipal.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtInscMunicipal.MaxLength = 10;
            this.txtInscMunicipal.MinimumSize = new System.Drawing.Size(113, 26);
            this.txtInscMunicipal.Name = "txtInscMunicipal";
            this.txtInscMunicipal.Size = new System.Drawing.Size(113, 26);
            this.txtInscMunicipal.TabIndex = 2;
            // 
            // lblInscMunicipal
            // 
            this.lblInscMunicipal.AutoSize = true;
            this.lblInscMunicipal.Location = new System.Drawing.Point(430, 22);
            this.lblInscMunicipal.Name = "lblInscMunicipal";
            this.lblInscMunicipal.Size = new System.Drawing.Size(108, 19);
            this.lblInscMunicipal.TabIndex = 67;
            this.lblInscMunicipal.Text = "Inscr. Municipal:";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Location = new System.Drawing.Point(522, 58);
            this.txtInscEstadual.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtInscEstadual.MaxLength = 10;
            this.txtInscEstadual.MinimumSize = new System.Drawing.Size(127, 26);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(127, 26);
            this.txtInscEstadual.TabIndex = 4;
            // 
            // lblInscEstadual
            // 
            this.lblInscEstadual.AutoSize = true;
            this.lblInscEstadual.Location = new System.Drawing.Point(416, 62);
            this.lblInscEstadual.Name = "lblInscEstadual";
            this.lblInscEstadual.Size = new System.Drawing.Size(100, 19);
            this.lblInscEstadual.TabIndex = 64;
            this.lblInscEstadual.Text = "Inscr. Estadual:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(76, 258);
            this.txtEmail.MaximumSize = new System.Drawing.Size(500, 0);
            this.txtEmail.MaxLength = 80;
            this.txtEmail.MinimumSize = new System.Drawing.Size(341, 26);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(341, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 262);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 60;
            this.lblEmail.Text = "Email:";
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(434, 218);
            this.mtxtTelefone.Mask = "(99)0000-0000";
            this.mtxtTelefone.MaximumSize = new System.Drawing.Size(107, 26);
            this.mtxtTelefone.MinimumSize = new System.Drawing.Size(107, 26);
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(107, 26);
            this.mtxtTelefone.TabIndex = 13;
            this.mtxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTelefoneContato
            // 
            this.lblTelefoneContato.AutoSize = true;
            this.lblTelefoneContato.Location = new System.Drawing.Point(365, 222);
            this.lblTelefoneContato.Name = "lblTelefoneContato";
            this.lblTelefoneContato.Size = new System.Drawing.Size(63, 19);
            this.lblTelefoneContato.TabIndex = 59;
            this.lblTelefoneContato.Text = "Telefone:";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(76, 218);
            this.txtContato.MaximumSize = new System.Drawing.Size(350, 0);
            this.txtContato.MaxLength = 100;
            this.txtContato.MinimumSize = new System.Drawing.Size(266, 26);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(266, 26);
            this.txtContato.TabIndex = 12;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(10, 222);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(61, 19);
            this.lblContato.TabIndex = 58;
            this.lblContato.Text = "Contato:";
            // 
            // cboCidade
            // 
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(416, 98);
            this.cboCidade.MaximumSize = new System.Drawing.Size(300, 0);
            this.cboCidade.MinimumSize = new System.Drawing.Size(233, 0);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(233, 27);
            this.cboCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(354, 102);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 19);
            this.lblCidade.TabIndex = 57;
            this.lblCidade.Text = "Cidade:";
            // 
            // cboUf
            // 
            this.cboUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUf.FormattingEnabled = true;
            this.cboUf.Location = new System.Drawing.Point(229, 98);
            this.cboUf.MaximumSize = new System.Drawing.Size(110, 0);
            this.cboUf.MinimumSize = new System.Drawing.Size(91, 0);
            this.cboUf.Name = "cboUf";
            this.cboUf.Size = new System.Drawing.Size(91, 27);
            this.cboUf.TabIndex = 6;
            this.cboUf.SelectionChangeCommitted += new System.EventHandler(this.cboUf_SelectionChangeCommitted_1);
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(194, 102);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(31, 19);
            this.lblUf.TabIndex = 56;
            this.lblUf.Text = "Uf.:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(398, 178);
            this.txtBairro.MaximumSize = new System.Drawing.Size(300, 0);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.MinimumSize = new System.Drawing.Size(251, 26);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(251, 26);
            this.txtBairro.TabIndex = 11;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(340, 182);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 19);
            this.lblBairro.TabIndex = 55;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(107, 178);
            this.txtComplemento.MaximumSize = new System.Drawing.Size(300, 0);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.MinimumSize = new System.Drawing.Size(211, 26);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(211, 26);
            this.txtComplemento.TabIndex = 10;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(10, 182);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(97, 19);
            this.lblComplemento.TabIndex = 54;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtNumeroLog
            // 
            this.txtNumeroLog.Location = new System.Drawing.Point(522, 138);
            this.txtNumeroLog.MaximumSize = new System.Drawing.Size(100, 0);
            this.txtNumeroLog.MaxLength = 10;
            this.txtNumeroLog.MinimumSize = new System.Drawing.Size(78, 26);
            this.txtNumeroLog.Name = "txtNumeroLog";
            this.txtNumeroLog.Size = new System.Drawing.Size(78, 26);
            this.txtNumeroLog.TabIndex = 9;
            // 
            // txtLogradrouro
            // 
            this.txtLogradrouro.Location = new System.Drawing.Point(96, 138);
            this.txtLogradrouro.MaximumSize = new System.Drawing.Size(500, 0);
            this.txtLogradrouro.MaxLength = 100;
            this.txtLogradrouro.MinimumSize = new System.Drawing.Size(358, 26);
            this.txtLogradrouro.Name = "txtLogradrouro";
            this.txtLogradrouro.Size = new System.Drawing.Size(358, 26);
            this.txtLogradrouro.TabIndex = 8;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(10, 142);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(84, 19);
            this.lblLogradouro.TabIndex = 48;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // btnCep
            // 
            this.btnCep.Image = global::EmitirNfse.UI.Properties.Resources.search_glyph;
            this.btnCep.Location = new System.Drawing.Point(145, 98);
            this.btnCep.MaximumSize = new System.Drawing.Size(29, 26);
            this.btnCep.MinimumSize = new System.Drawing.Size(29, 26);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(29, 26);
            this.btnCep.TabIndex = 63;
            this.btnCep.UseVisualStyleBackColor = true;
            this.btnCep.Click += new System.EventHandler(this.btnCep_Click);
            // 
            // mtxtCep
            // 
            this.mtxtCep.Location = new System.Drawing.Point(55, 98);
            this.mtxtCep.Mask = "99999-999";
            this.mtxtCep.MaximumSize = new System.Drawing.Size(88, 26);
            this.mtxtCep.MinimumSize = new System.Drawing.Size(88, 26);
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.Size = new System.Drawing.Size(88, 26);
            this.mtxtCep.TabIndex = 5;
            this.mtxtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(10, 102);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(38, 19);
            this.lblCep.TabIndex = 44;
            this.lblCep.Text = "Cep:";
            // 
            // mtxtCpfCnpj
            // 
            this.mtxtCpfCnpj.Location = new System.Drawing.Point(279, 18);
            this.mtxtCpfCnpj.Mask = "00,000,000/0000-00";
            this.mtxtCpfCnpj.MaximumSize = new System.Drawing.Size(150, 26);
            this.mtxtCpfCnpj.MinimumSize = new System.Drawing.Size(138, 26);
            this.mtxtCpfCnpj.Name = "mtxtCpfCnpj";
            this.mtxtCpfCnpj.Size = new System.Drawing.Size(138, 26);
            this.mtxtCpfCnpj.TabIndex = 1;
            this.mtxtCpfCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(234, 22);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(42, 19);
            this.lblCpfCnpj.TabIndex = 41;
            this.lblCpfCnpj.Text = "Cnpj:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Pessoa Jurídica",
            "Pessoa Física"});
            this.cboTipo.Location = new System.Drawing.Point(56, 18);
            this.cboTipo.MaximumSize = new System.Drawing.Size(170, 0);
            this.cboTipo.MinimumSize = new System.Drawing.Size(162, 0);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(162, 27);
            this.cboTipo.TabIndex = 0;
            this.cboTipo.SelectionChangeCommitted += new System.EventHandler(this.cboTipo_SelectionChangeCommitted);
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.Location = new System.Drawing.Point(10, 22);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(39, 19);
            this.lblTipoPessoa.TabIndex = 37;
            this.lblTipoPessoa.Text = "Tipo:";
            // 
            // txtNomeRazaoSocial
            // 
            this.txtNomeRazaoSocial.Location = new System.Drawing.Point(107, 58);
            this.txtNomeRazaoSocial.MaximumSize = new System.Drawing.Size(320, 0);
            this.txtNomeRazaoSocial.MaxLength = 115;
            this.txtNomeRazaoSocial.MinimumSize = new System.Drawing.Size(290, 26);
            this.txtNomeRazaoSocial.Name = "txtNomeRazaoSocial";
            this.txtNomeRazaoSocial.Size = new System.Drawing.Size(290, 26);
            this.txtNomeRazaoSocial.TabIndex = 3;
            // 
            // lblNomeRazaoSocial
            // 
            this.lblNomeRazaoSocial.AutoSize = true;
            this.lblNomeRazaoSocial.Location = new System.Drawing.Point(10, 62);
            this.lblNomeRazaoSocial.Name = "lblNomeRazaoSocial";
            this.lblNomeRazaoSocial.Size = new System.Drawing.Size(91, 19);
            this.lblNomeRazaoSocial.TabIndex = 35;
            this.lblNomeRazaoSocial.Text = "Razão Social:";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovo.Image = global::EmitirNfse.UI.Properties.Resources.NewDocumentHS;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(174, 542);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 29);
            this.btnNovo.TabIndex = 68;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Image = global::EmitirNfse.UI.Properties.Resources._305_Close_16x16_72;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(403, 542);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 29);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvar.Image = global::EmitirNfse.UI.Properties.Resources.saveHS;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(286, 542);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 29);
            this.btnSalvar.TabIndex = 66;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Items.AddRange(new object[] {
            "Razão Social",
            "CNPJ"});
            this.cbPesquisa.Location = new System.Drawing.Point(381, 6);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(191, 27);
            this.cbPesquisa.TabIndex = 71;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(69, 6);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(306, 26);
            this.txtPesquisa.TabIndex = 70;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(6, 10);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(65, 19);
            this.lblPesquisa.TabIndex = 69;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(579, 5);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 29);
            this.btnPesquisa.TabIndex = 72;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(666, 574);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.cbPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.dgvClientes);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(674, 515);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCliente_FormClosing);
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private System.Windows.Forms.Label lblInscEstadual;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.Label lblTelefoneContato;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox cboUf;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumeroLog;
        private System.Windows.Forms.Label lblNumeroLog;
        private System.Windows.Forms.TextBox txtLogradrouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Button btnCep;
        private System.Windows.Forms.MaskedTextBox mtxtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.MaskedTextBox mtxtCpfCnpj;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipoPessoa;
        private System.Windows.Forms.TextBox txtNomeRazaoSocial;
        private System.Windows.Forms.Label lblNomeRazaoSocial;
        private System.Windows.Forms.TextBox txtInscMunicipal;
        private System.Windows.Forms.Label lblInscMunicipal;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.LinkLabel lnkLabel;
    }
}