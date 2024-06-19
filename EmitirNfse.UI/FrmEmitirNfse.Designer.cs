namespace EmitirNfse.UI
{
    partial class FrmEmitirNfse
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.cboServico = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.lblValorDeducoes = new System.Windows.Forms.Label();
            this.txtValorDeducoes = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtValorIr = new System.Windows.Forms.TextBox();
            this.lblValorIr = new System.Windows.Forms.Label();
            this.txtValorCsll = new System.Windows.Forms.TextBox();
            this.lblValorCsll = new System.Windows.Forms.Label();
            this.txtValorPis = new System.Windows.Forms.TextBox();
            this.lblPis = new System.Windows.Forms.Label();
            this.txtValorCofins = new System.Windows.Forms.TextBox();
            this.lblCofins = new System.Windows.Forms.Label();
            this.txtDescontoIncondicionado = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblDataEmissao = new System.Windows.Forms.Label();
            this.grpbxIssRetido = new System.Windows.Forms.GroupBox();
            this.chkIssRetido = new System.Windows.Forms.CheckBox();
            this.txtValorIssRetido = new System.Windows.Forms.TextBox();
            this.lblValorIssRetido = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtValorIss = new System.Windows.Forms.TextBox();
            this.lblValorIss = new System.Windows.Forms.Label();
            this.txtValorLiquido = new System.Windows.Forms.TextBox();
            this.lblValorNfse = new System.Windows.Forms.Label();
            this.grpbxValores = new System.Windows.Forms.GroupBox();
            this.lblOutrasRetencoes = new System.Windows.Forms.Label();
            this.txtOutrasRetencoes = new System.Windows.Forms.TextBox();
            this.lblDescontoCondicionado = new System.Windows.Forms.Label();
            this.txtDescontoCondicionado = new System.Windows.Forms.TextBox();
            this.grpbxImpostosFederais = new System.Windows.Forms.GroupBox();
            this.lblValorInss = new System.Windows.Forms.Label();
            this.txtValorInss = new System.Windows.Forms.TextBox();
            this.grpbxTotalizador = new System.Windows.Forms.GroupBox();
            this.lblBaseCalculo = new System.Windows.Forms.Label();
            this.txtBaseCalculo = new System.Windows.Forms.TextBox();
            this.btnCadastraTomador = new System.Windows.Forms.Button();
            this.lblNatOpercao = new System.Windows.Forms.Label();
            this.cboNaturezaOperacao = new System.Windows.Forms.ComboBox();
            this.grpbxIssRetido.SuspendLayout();
            this.grpbxValores.SuspendLayout();
            this.grpbxImpostosFederais.SuspendLayout();
            this.grpbxTotalizador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 28);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(67, 19);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Tomador:";
            // 
            // cboCliente
            // 
            this.cboCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(83, 24);
            this.cboCliente.MinimumSize = new System.Drawing.Size(312, 0);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(465, 27);
            this.cboCliente.TabIndex = 0;
            this.cboCliente.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboCliente_DrawItem);
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(13, 71);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(58, 19);
            this.lblServico.TabIndex = 2;
            this.lblServico.Text = "Serviço:";
            // 
            // cboServico
            // 
            this.cboServico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServico.FormattingEnabled = true;
            this.cboServico.Location = new System.Drawing.Point(74, 67);
            this.cboServico.MinimumSize = new System.Drawing.Size(457, 0);
            this.cboServico.Name = "cboServico";
            this.cboServico.Size = new System.Drawing.Size(457, 27);
            this.cboServico.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(5, 22);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(94, 19);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Valor Serviço:";
            // 
            // txtValorServico
            // 
            this.txtValorServico.Location = new System.Drawing.Point(99, 18);
            this.txtValorServico.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtValorServico.MaxLength = 10;
            this.txtValorServico.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Size = new System.Drawing.Size(79, 26);
            this.txtValorServico.TabIndex = 0;
            this.txtValorServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorServico.Leave += new System.EventHandler(this.txtValorServico_Leave);
            // 
            // lblValorDeducoes
            // 
            this.lblValorDeducoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValorDeducoes.AutoSize = true;
            this.lblValorDeducoes.Location = new System.Drawing.Point(181, 22);
            this.lblValorDeducoes.MinimumSize = new System.Drawing.Size(109, 19);
            this.lblValorDeducoes.Name = "lblValorDeducoes";
            this.lblValorDeducoes.Size = new System.Drawing.Size(109, 19);
            this.lblValorDeducoes.TabIndex = 7;
            this.lblValorDeducoes.Text = "Valor Deduções:";
            // 
            // txtValorDeducoes
            // 
            this.txtValorDeducoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorDeducoes.Location = new System.Drawing.Point(290, 18);
            this.txtValorDeducoes.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtValorDeducoes.MaxLength = 10;
            this.txtValorDeducoes.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtValorDeducoes.Name = "txtValorDeducoes";
            this.txtValorDeducoes.Size = new System.Drawing.Size(79, 26);
            this.txtValorDeducoes.TabIndex = 1;
            this.txtValorDeducoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorDeducoes.Leave += new System.EventHandler(this.txtValorDeducoes_Leave);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(13, 110);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(86, 19);
            this.lblObservacao.TabIndex = 9;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.Location = new System.Drawing.Point(101, 110);
            this.txtObservacao.MinimumSize = new System.Drawing.Size(430, 70);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservacao.Size = new System.Drawing.Size(430, 70);
            this.txtObservacao.TabIndex = 2;
            // 
            // txtValorIr
            // 
            this.txtValorIr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorIr.Location = new System.Drawing.Point(453, 18);
            this.txtValorIr.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtValorIr.MaxLength = 10;
            this.txtValorIr.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtValorIr.Name = "txtValorIr";
            this.txtValorIr.Size = new System.Drawing.Size(79, 26);
            this.txtValorIr.TabIndex = 2;
            this.txtValorIr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorIr
            // 
            this.lblValorIr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorIr.AutoSize = true;
            this.lblValorIr.Location = new System.Drawing.Point(383, 22);
            this.lblValorIr.Name = "lblValorIr";
            this.lblValorIr.Size = new System.Drawing.Size(63, 19);
            this.lblValorIr.TabIndex = 11;
            this.lblValorIr.Text = "Valor IR:";
            // 
            // txtValorCsll
            // 
            this.txtValorCsll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorCsll.Location = new System.Drawing.Point(276, 56);
            this.txtValorCsll.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtValorCsll.MaxLength = 10;
            this.txtValorCsll.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtValorCsll.Name = "txtValorCsll";
            this.txtValorCsll.Size = new System.Drawing.Size(79, 26);
            this.txtValorCsll.TabIndex = 4;
            this.txtValorCsll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorCsll
            // 
            this.lblValorCsll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValorCsll.AutoSize = true;
            this.lblValorCsll.Location = new System.Drawing.Point(182, 60);
            this.lblValorCsll.Name = "lblValorCsll";
            this.lblValorCsll.Size = new System.Drawing.Size(86, 19);
            this.lblValorCsll.TabIndex = 13;
            this.lblValorCsll.Text = "Valor CSLL:";
            // 
            // txtValorPis
            // 
            this.txtValorPis.Location = new System.Drawing.Point(81, 18);
            this.txtValorPis.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtValorPis.MaxLength = 10;
            this.txtValorPis.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtValorPis.Name = "txtValorPis";
            this.txtValorPis.Size = new System.Drawing.Size(79, 26);
            this.txtValorPis.TabIndex = 0;
            this.txtValorPis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPis
            // 
            this.lblPis.AutoSize = true;
            this.lblPis.Location = new System.Drawing.Point(5, 22);
            this.lblPis.Name = "lblPis";
            this.lblPis.Size = new System.Drawing.Size(71, 19);
            this.lblPis.TabIndex = 15;
            this.lblPis.Text = "Valor PIS:";
            // 
            // txtValorCofins
            // 
            this.txtValorCofins.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorCofins.Location = new System.Drawing.Point(275, 18);
            this.txtValorCofins.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtValorCofins.MaxLength = 10;
            this.txtValorCofins.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtValorCofins.Name = "txtValorCofins";
            this.txtValorCofins.Size = new System.Drawing.Size(79, 26);
            this.txtValorCofins.TabIndex = 1;
            this.txtValorCofins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCofins
            // 
            this.lblCofins.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCofins.AutoSize = true;
            this.lblCofins.Location = new System.Drawing.Point(182, 22);
            this.lblCofins.Name = "lblCofins";
            this.lblCofins.Size = new System.Drawing.Size(87, 19);
            this.lblCofins.TabIndex = 17;
            this.lblCofins.Text = "Valor Cofins:";
            // 
            // txtDescontoIncondicionado
            // 
            this.txtDescontoIncondicionado.Location = new System.Drawing.Point(180, 54);
            this.txtDescontoIncondicionado.MaxLength = 10;
            this.txtDescontoIncondicionado.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtDescontoIncondicionado.Name = "txtDescontoIncondicionado";
            this.txtDescontoIncondicionado.Size = new System.Drawing.Size(79, 26);
            this.txtDescontoIncondicionado.TabIndex = 3;
            this.txtDescontoIncondicionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescontoIncondicionado.Leave += new System.EventHandler(this.txtDescontoIncondicionado_Leave);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(5, 57);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(173, 19);
            this.lblDesconto.TabIndex = 19;
            this.lblDesconto.Text = "Desconto Incondicionados:";
            // 
            // lblDataEmissao
            // 
            this.lblDataEmissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataEmissao.AutoSize = true;
            this.lblDataEmissao.Location = new System.Drawing.Point(86, 3);
            this.lblDataEmissao.Name = "lblDataEmissao";
            this.lblDataEmissao.Size = new System.Drawing.Size(0, 19);
            this.lblDataEmissao.TabIndex = 21;
            // 
            // grpbxIssRetido
            // 
            this.grpbxIssRetido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxIssRetido.Controls.Add(this.chkIssRetido);
            this.grpbxIssRetido.Controls.Add(this.txtValorIssRetido);
            this.grpbxIssRetido.Controls.Add(this.lblValorIssRetido);
            this.grpbxIssRetido.Location = new System.Drawing.Point(15, 336);
            this.grpbxIssRetido.MinimumSize = new System.Drawing.Size(574, 56);
            this.grpbxIssRetido.Name = "grpbxIssRetido";
            this.grpbxIssRetido.Size = new System.Drawing.Size(574, 56);
            this.grpbxIssRetido.TabIndex = 6;
            this.grpbxIssRetido.TabStop = false;
            this.grpbxIssRetido.Text = "Iss Retido";
            // 
            // chkIssRetido
            // 
            this.chkIssRetido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIssRetido.AutoSize = true;
            this.chkIssRetido.Location = new System.Drawing.Point(5, 26);
            this.chkIssRetido.Name = "chkIssRetido";
            this.chkIssRetido.Size = new System.Drawing.Size(43, 17);
            this.chkIssRetido.TabIndex = 0;
            this.chkIssRetido.Text = "Sim";
            this.chkIssRetido.UseVisualStyleBackColor = true;
            this.chkIssRetido.CheckedChanged += new System.EventHandler(this.chkIssRetido_CheckedChanged);
            // 
            // txtValorIssRetido
            // 
            this.txtValorIssRetido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorIssRetido.Location = new System.Drawing.Point(209, 23);
            this.txtValorIssRetido.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtValorIssRetido.MaxLength = 10;
            this.txtValorIssRetido.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtValorIssRetido.Name = "txtValorIssRetido";
            this.txtValorIssRetido.Size = new System.Drawing.Size(79, 26);
            this.txtValorIssRetido.TabIndex = 1;
            this.txtValorIssRetido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorIssRetido
            // 
            this.lblValorIssRetido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorIssRetido.AutoSize = true;
            this.lblValorIssRetido.Location = new System.Drawing.Point(120, 27);
            this.lblValorIssRetido.Name = "lblValorIssRetido";
            this.lblValorIssRetido.Size = new System.Drawing.Size(73, 19);
            this.lblValorIssRetido.TabIndex = 30;
            this.lblValorIssRetido.Text = "Iss Retido:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmar.Location = new System.Drawing.Point(195, 564);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(92, 39);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Enviar Nfse";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Location = new System.Drawing.Point(315, 564);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 39);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtValorIss
            // 
            this.txtValorIss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorIss.Location = new System.Drawing.Point(480, 18);
            this.txtValorIss.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtValorIss.MaxLength = 10;
            this.txtValorIss.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtValorIss.Name = "txtValorIss";
            this.txtValorIss.Size = new System.Drawing.Size(79, 26);
            this.txtValorIss.TabIndex = 2;
            this.txtValorIss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorIss
            // 
            this.lblValorIss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorIss.AutoSize = true;
            this.lblValorIss.Location = new System.Drawing.Point(406, 22);
            this.lblValorIss.Name = "lblValorIss";
            this.lblValorIss.Size = new System.Drawing.Size(65, 19);
            this.lblValorIss.TabIndex = 25;
            this.lblValorIss.Text = "Valor Iss:";
            // 
            // txtValorLiquido
            // 
            this.txtValorLiquido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValorLiquido.Location = new System.Drawing.Point(300, 18);
            this.txtValorLiquido.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtValorLiquido.MaxLength = 10;
            this.txtValorLiquido.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtValorLiquido.Name = "txtValorLiquido";
            this.txtValorLiquido.Size = new System.Drawing.Size(79, 26);
            this.txtValorLiquido.TabIndex = 1;
            this.txtValorLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorNfse
            // 
            this.lblValorNfse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValorNfse.AutoSize = true;
            this.lblValorNfse.Location = new System.Drawing.Point(200, 22);
            this.lblValorNfse.Name = "lblValorNfse";
            this.lblValorNfse.Size = new System.Drawing.Size(94, 19);
            this.lblValorNfse.TabIndex = 28;
            this.lblValorNfse.Text = "Valor Líquido:";
            // 
            // grpbxValores
            // 
            this.grpbxValores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxValores.Controls.Add(this.lblValorDeducoes);
            this.grpbxValores.Controls.Add(this.txtValorDeducoes);
            this.grpbxValores.Controls.Add(this.lblOutrasRetencoes);
            this.grpbxValores.Controls.Add(this.txtOutrasRetencoes);
            this.grpbxValores.Controls.Add(this.lblDescontoCondicionado);
            this.grpbxValores.Controls.Add(this.txtDescontoCondicionado);
            this.grpbxValores.Controls.Add(this.lblValor);
            this.grpbxValores.Controls.Add(this.txtValorServico);
            this.grpbxValores.Controls.Add(this.lblDesconto);
            this.grpbxValores.Controls.Add(this.txtDescontoIncondicionado);
            this.grpbxValores.Location = new System.Drawing.Point(15, 230);
            this.grpbxValores.MinimumSize = new System.Drawing.Size(574, 105);
            this.grpbxValores.Name = "grpbxValores";
            this.grpbxValores.Size = new System.Drawing.Size(574, 105);
            this.grpbxValores.TabIndex = 5;
            this.grpbxValores.TabStop = false;
            this.grpbxValores.Text = "Valores";
            // 
            // lblOutrasRetencoes
            // 
            this.lblOutrasRetencoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutrasRetencoes.AutoSize = true;
            this.lblOutrasRetencoes.Location = new System.Drawing.Point(370, 22);
            this.lblOutrasRetencoes.Name = "lblOutrasRetencoes";
            this.lblOutrasRetencoes.Size = new System.Drawing.Size(120, 19);
            this.lblOutrasRetencoes.TabIndex = 23;
            this.lblOutrasRetencoes.Text = "Outras Retenções:";
            // 
            // txtOutrasRetencoes
            // 
            this.txtOutrasRetencoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutrasRetencoes.Location = new System.Drawing.Point(489, 18);
            this.txtOutrasRetencoes.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtOutrasRetencoes.MaxLength = 10;
            this.txtOutrasRetencoes.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtOutrasRetencoes.Name = "txtOutrasRetencoes";
            this.txtOutrasRetencoes.Size = new System.Drawing.Size(79, 26);
            this.txtOutrasRetencoes.TabIndex = 2;
            this.txtOutrasRetencoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutrasRetencoes.Leave += new System.EventHandler(this.txtOutrasRetencoes_Leave);
            // 
            // lblDescontoCondicionado
            // 
            this.lblDescontoCondicionado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescontoCondicionado.AutoSize = true;
            this.lblDescontoCondicionado.Location = new System.Drawing.Point(271, 57);
            this.lblDescontoCondicionado.Name = "lblDescontoCondicionado";
            this.lblDescontoCondicionado.Size = new System.Drawing.Size(165, 19);
            this.lblDescontoCondicionado.TabIndex = 21;
            this.lblDescontoCondicionado.Text = "Desconto Condicionados:";
            // 
            // txtDescontoCondicionado
            // 
            this.txtDescontoCondicionado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescontoCondicionado.Location = new System.Drawing.Point(442, 54);
            this.txtDescontoCondicionado.MaxLength = 10;
            this.txtDescontoCondicionado.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtDescontoCondicionado.Name = "txtDescontoCondicionado";
            this.txtDescontoCondicionado.Size = new System.Drawing.Size(79, 26);
            this.txtDescontoCondicionado.TabIndex = 4;
            this.txtDescontoCondicionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescontoCondicionado.Leave += new System.EventHandler(this.txtDescontoCondicionado_Leave);
            // 
            // grpbxImpostosFederais
            // 
            this.grpbxImpostosFederais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxImpostosFederais.Controls.Add(this.lblValorInss);
            this.grpbxImpostosFederais.Controls.Add(this.txtValorInss);
            this.grpbxImpostosFederais.Controls.Add(this.lblPis);
            this.grpbxImpostosFederais.Controls.Add(this.txtValorPis);
            this.grpbxImpostosFederais.Controls.Add(this.lblCofins);
            this.grpbxImpostosFederais.Controls.Add(this.txtValorCofins);
            this.grpbxImpostosFederais.Controls.Add(this.lblValorIr);
            this.grpbxImpostosFederais.Controls.Add(this.txtValorIr);
            this.grpbxImpostosFederais.Controls.Add(this.lblValorCsll);
            this.grpbxImpostosFederais.Controls.Add(this.txtValorCsll);
            this.grpbxImpostosFederais.Location = new System.Drawing.Point(15, 399);
            this.grpbxImpostosFederais.MinimumSize = new System.Drawing.Size(574, 86);
            this.grpbxImpostosFederais.Name = "grpbxImpostosFederais";
            this.grpbxImpostosFederais.Size = new System.Drawing.Size(574, 86);
            this.grpbxImpostosFederais.TabIndex = 7;
            this.grpbxImpostosFederais.TabStop = false;
            this.grpbxImpostosFederais.Text = "Impostos Federais";
            // 
            // lblValorInss
            // 
            this.lblValorInss.AutoSize = true;
            this.lblValorInss.Location = new System.Drawing.Point(5, 60);
            this.lblValorInss.Name = "lblValorInss";
            this.lblValorInss.Size = new System.Drawing.Size(72, 19);
            this.lblValorInss.TabIndex = 19;
            this.lblValorInss.Text = "Valor Inss:";
            // 
            // txtValorInss
            // 
            this.txtValorInss.Location = new System.Drawing.Point(81, 56);
            this.txtValorInss.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtValorInss.MaxLength = 10;
            this.txtValorInss.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtValorInss.Name = "txtValorInss";
            this.txtValorInss.Size = new System.Drawing.Size(79, 26);
            this.txtValorInss.TabIndex = 3;
            this.txtValorInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpbxTotalizador
            // 
            this.grpbxTotalizador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxTotalizador.Controls.Add(this.lblBaseCalculo);
            this.grpbxTotalizador.Controls.Add(this.txtBaseCalculo);
            this.grpbxTotalizador.Controls.Add(this.lblValorIss);
            this.grpbxTotalizador.Controls.Add(this.txtValorIss);
            this.grpbxTotalizador.Controls.Add(this.lblValorNfse);
            this.grpbxTotalizador.Controls.Add(this.txtValorLiquido);
            this.grpbxTotalizador.Location = new System.Drawing.Point(14, 492);
            this.grpbxTotalizador.MinimumSize = new System.Drawing.Size(574, 66);
            this.grpbxTotalizador.Name = "grpbxTotalizador";
            this.grpbxTotalizador.Size = new System.Drawing.Size(574, 66);
            this.grpbxTotalizador.TabIndex = 8;
            this.grpbxTotalizador.TabStop = false;
            this.grpbxTotalizador.Text = "Totalizador";
            // 
            // lblBaseCalculo
            // 
            this.lblBaseCalculo.AutoSize = true;
            this.lblBaseCalculo.Location = new System.Drawing.Point(6, 22);
            this.lblBaseCalculo.Name = "lblBaseCalculo";
            this.lblBaseCalculo.Size = new System.Drawing.Size(92, 19);
            this.lblBaseCalculo.TabIndex = 30;
            this.lblBaseCalculo.Text = "Base Cálculo:";
            // 
            // txtBaseCalculo
            // 
            this.txtBaseCalculo.Location = new System.Drawing.Point(106, 18);
            this.txtBaseCalculo.MaximumSize = new System.Drawing.Size(200, 0);
            this.txtBaseCalculo.MaxLength = 10;
            this.txtBaseCalculo.MinimumSize = new System.Drawing.Size(79, 26);
            this.txtBaseCalculo.Name = "txtBaseCalculo";
            this.txtBaseCalculo.Size = new System.Drawing.Size(79, 26);
            this.txtBaseCalculo.TabIndex = 0;
            this.txtBaseCalculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCadastraTomador
            // 
            this.btnCadastraTomador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastraTomador.Image = global::EmitirNfse.UI.Properties.Resources.base_plus_sign_32;
            this.btnCadastraTomador.Location = new System.Drawing.Point(554, 24);
            this.btnCadastraTomador.Name = "btnCadastraTomador";
            this.btnCadastraTomador.Size = new System.Drawing.Size(34, 27);
            this.btnCadastraTomador.TabIndex = 23;
            this.btnCadastraTomador.UseVisualStyleBackColor = true;
            this.btnCadastraTomador.Click += new System.EventHandler(this.btnCadastraTomador_Click);
            // 
            // lblNatOpercao
            // 
            this.lblNatOpercao.AutoSize = true;
            this.lblNatOpercao.Location = new System.Drawing.Point(13, 194);
            this.lblNatOpercao.Name = "lblNatOpercao";
            this.lblNatOpercao.Size = new System.Drawing.Size(132, 19);
            this.lblNatOpercao.TabIndex = 24;
            this.lblNatOpercao.Text = "Natureza Operação:";
            // 
            // cboNaturezaOperacao
            // 
            this.cboNaturezaOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNaturezaOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNaturezaOperacao.FormattingEnabled = true;
            this.cboNaturezaOperacao.Location = new System.Drawing.Point(143, 191);
            this.cboNaturezaOperacao.MinimumSize = new System.Drawing.Size(264, 0);
            this.cboNaturezaOperacao.Name = "cboNaturezaOperacao";
            this.cboNaturezaOperacao.Size = new System.Drawing.Size(388, 27);
            this.cboNaturezaOperacao.TabIndex = 4;
            // 
            // FrmEmitirNfse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(603, 615);
            this.Controls.Add(this.cboNaturezaOperacao);
            this.Controls.Add(this.lblNatOpercao);
            this.Controls.Add(this.btnCadastraTomador);
            this.Controls.Add(this.grpbxTotalizador);
            this.Controls.Add(this.grpbxImpostosFederais);
            this.Controls.Add(this.grpbxValores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpbxIssRetido);
            this.Controls.Add(this.lblDataEmissao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.cboServico);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblCliente);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(611, 642);
            this.Name = "FrmEmitirNfse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emitir Nfse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmitirNfse_FormClosing);
            this.Load += new System.EventHandler(this.FrmEmitirNfse_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEmitirNfse_KeyDown);
            this.grpbxIssRetido.ResumeLayout(false);
            this.grpbxIssRetido.PerformLayout();
            this.grpbxValores.ResumeLayout(false);
            this.grpbxValores.PerformLayout();
            this.grpbxImpostosFederais.ResumeLayout(false);
            this.grpbxImpostosFederais.PerformLayout();
            this.grpbxTotalizador.ResumeLayout(false);
            this.grpbxTotalizador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.ComboBox cboServico;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValorServico;
        private System.Windows.Forms.Label lblValorDeducoes;
        private System.Windows.Forms.TextBox txtValorDeducoes;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtValorIr;
        private System.Windows.Forms.Label lblValorIr;
        private System.Windows.Forms.TextBox txtValorCsll;
        private System.Windows.Forms.Label lblValorCsll;
        private System.Windows.Forms.TextBox txtValorPis;
        private System.Windows.Forms.Label lblPis;
        private System.Windows.Forms.TextBox txtValorCofins;
        private System.Windows.Forms.Label lblCofins;
        private System.Windows.Forms.TextBox txtDescontoIncondicionado;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblDataEmissao;
        private System.Windows.Forms.GroupBox grpbxIssRetido;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtValorIss;
        private System.Windows.Forms.Label lblValorIss;
        private System.Windows.Forms.TextBox txtValorLiquido;
        private System.Windows.Forms.Label lblValorNfse;
        private System.Windows.Forms.TextBox txtValorIssRetido;
        private System.Windows.Forms.Label lblValorIssRetido;
        private System.Windows.Forms.GroupBox grpbxValores;
        private System.Windows.Forms.Label lblOutrasRetencoes;
        private System.Windows.Forms.TextBox txtOutrasRetencoes;
        private System.Windows.Forms.Label lblDescontoCondicionado;
        private System.Windows.Forms.TextBox txtDescontoCondicionado;
        private System.Windows.Forms.CheckBox chkIssRetido;
        private System.Windows.Forms.GroupBox grpbxImpostosFederais;
        private System.Windows.Forms.Label lblValorInss;
        private System.Windows.Forms.TextBox txtValorInss;
        private System.Windows.Forms.GroupBox grpbxTotalizador;
        private System.Windows.Forms.Label lblBaseCalculo;
        private System.Windows.Forms.TextBox txtBaseCalculo;
        private System.Windows.Forms.Button btnCadastraTomador;
        private System.Windows.Forms.Label lblNatOpercao;
        private System.Windows.Forms.ComboBox cboNaturezaOperacao;
    }
}