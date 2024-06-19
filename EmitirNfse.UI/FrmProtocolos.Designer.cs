namespace EmitirNfse.UI
{
    partial class FrmProtocolos
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
            this.dgvProtocolos = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSubstituir = new System.Windows.Forms.Button();
            this.btnRemoverSelecao = new System.Windows.Forms.Button();
            this.btnSelecionarTodos = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.lnkLabel = new System.Windows.Forms.LinkLabel();
            this.chkSemRetorno = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocolos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProtocolos
            // 
            this.dgvProtocolos.AllowUserToAddRows = false;
            this.dgvProtocolos.AllowUserToDeleteRows = false;
            this.dgvProtocolos.AllowUserToOrderColumns = true;
            this.dgvProtocolos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProtocolos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProtocolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProtocolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            this.dgvProtocolos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProtocolos.Location = new System.Drawing.Point(4, 36);
            this.dgvProtocolos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProtocolos.Name = "dgvProtocolos";
            this.dgvProtocolos.RowHeadersVisible = false;
            this.dgvProtocolos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProtocolos.Size = new System.Drawing.Size(1043, 421);
            this.dgvProtocolos.TabIndex = 0;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Width = 78;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConsultar.Location = new System.Drawing.Point(335, 478);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 38);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Rps";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.Location = new System.Drawing.Point(469, 478);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 38);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar Rps";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSubstituir
            // 
            this.btnSubstituir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubstituir.Location = new System.Drawing.Point(603, 478);
            this.btnSubstituir.Name = "btnSubstituir";
            this.btnSubstituir.Size = new System.Drawing.Size(112, 38);
            this.btnSubstituir.TabIndex = 3;
            this.btnSubstituir.Text = "Substituir Rps";
            this.btnSubstituir.UseVisualStyleBackColor = true;
            this.btnSubstituir.Click += new System.EventHandler(this.btnSubstituir_Click);
            // 
            // btnRemoverSelecao
            // 
            this.btnRemoverSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverSelecao.Location = new System.Drawing.Point(97, 473);
            this.btnRemoverSelecao.Name = "btnRemoverSelecao";
            this.btnRemoverSelecao.Size = new System.Drawing.Size(87, 49);
            this.btnRemoverSelecao.TabIndex = 9;
            this.btnRemoverSelecao.Text = "Remover Seleção";
            this.btnRemoverSelecao.UseVisualStyleBackColor = true;
            this.btnRemoverSelecao.Click += new System.EventHandler(this.btnRemoverSelecao_Click);
            // 
            // btnSelecionarTodos
            // 
            this.btnSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelecionarTodos.Location = new System.Drawing.Point(4, 473);
            this.btnSelecionarTodos.Name = "btnSelecionarTodos";
            this.btnSelecionarTodos.Size = new System.Drawing.Size(87, 49);
            this.btnSelecionarTodos.TabIndex = 8;
            this.btnSelecionarTodos.Text = "Selecionar Todos";
            this.btnSelecionarTodos.UseVisualStyleBackColor = true;
            this.btnSelecionarTodos.Click += new System.EventHandler(this.btnSelecionarTodos_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(4, 8);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(65, 19);
            this.lblPesquisa.TabIndex = 10;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(67, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(353, 26);
            this.txtPesquisa.TabIndex = 11;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(686, 3);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 29);
            this.btnPesquisa.TabIndex = 12;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Items.AddRange(new object[] {
            "Razão Social",
            "CNPJ",
            "Número Nfse",
            "Protocolo"});
            this.cbPesquisa.Location = new System.Drawing.Point(426, 4);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(235, 27);
            this.cbPesquisa.TabIndex = 13;
            // 
            // lnkLabel
            // 
            this.lnkLabel.AutoSize = true;
            this.lnkLabel.Location = new System.Drawing.Point(771, 8);
            this.lnkLabel.Name = "lnkLabel";
            this.lnkLabel.Size = new System.Drawing.Size(119, 19);
            this.lnkLabel.TabIndex = 14;
            this.lnkLabel.TabStop = true;
            this.lnkLabel.Text = "Desfazer Pesquisa";
            this.lnkLabel.Visible = false;
            this.lnkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabel_LinkClicked);
            // 
            // chkSemRetorno
            // 
            this.chkSemRetorno.AutoSize = true;
            this.chkSemRetorno.Location = new System.Drawing.Point(897, 6);
            this.chkSemRetorno.Name = "chkSemRetorno";
            this.chkSemRetorno.Size = new System.Drawing.Size(150, 23);
            this.chkSemRetorno.TabIndex = 15;
            this.chkSemRetorno.Text = "Apenas sem retorno";
            this.chkSemRetorno.UseVisualStyleBackColor = true;
            this.chkSemRetorno.CheckedChanged += new System.EventHandler(this.chkSemRetorno_CheckedChanged);
            // 
            // FrmProtocolos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1051, 529);
            this.Controls.Add(this.chkSemRetorno);
            this.Controls.Add(this.lnkLabel);
            this.Controls.Add(this.cbPesquisa);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.btnRemoverSelecao);
            this.Controls.Add(this.btnSelecionarTodos);
            this.Controls.Add(this.btnSubstituir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvProtocolos);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProtocolos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protocolos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProtocolos_FormClosing);
            this.Load += new System.EventHandler(this.FrmProtocolos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProtocolos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProtocolos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSubstituir;
        private System.Windows.Forms.Button btnRemoverSelecao;
        private System.Windows.Forms.Button btnSelecionarTodos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.LinkLabel lnkLabel;
        private System.Windows.Forms.CheckBox chkSemRetorno;
    }
}