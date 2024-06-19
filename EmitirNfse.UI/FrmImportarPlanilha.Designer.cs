namespace EmitirNfse.UI
{
    partial class FrmImportarPlanilha
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
            this.tbcImportar = new System.Windows.Forms.TabControl();
            this.tbpImportarCadastro = new System.Windows.Forms.TabPage();
            this.lblBarraProgresso = new System.Windows.Forms.Label();
            this.PbImportacao = new System.Windows.Forms.ProgressBar();
            this.btnImportarCadastro = new System.Windows.Forms.Button();
            this.tbpFaturar = new System.Windows.Forms.TabPage();
            this.btnRemoverSelecao = new System.Windows.Forms.Button();
            this.btnSelecionarTodos = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnImportarFaturamento = new System.Windows.Forms.Button();
            this.dgvImportarFaturamento = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblDescricaoServico = new System.Windows.Forms.Label();
            this.pbEnvioRps = new System.Windows.Forms.ProgressBar();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.tbcImportar.SuspendLayout();
            this.tbpImportarCadastro.SuspendLayout();
            this.tbpFaturar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportarFaturamento)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcImportar
            // 
            this.tbcImportar.Controls.Add(this.tbpImportarCadastro);
            this.tbcImportar.Controls.Add(this.tbpFaturar);
            this.tbcImportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcImportar.Location = new System.Drawing.Point(0, 0);
            this.tbcImportar.Name = "tbcImportar";
            this.tbcImportar.SelectedIndex = 0;
            this.tbcImportar.Size = new System.Drawing.Size(597, 397);
            this.tbcImportar.TabIndex = 3;
            // 
            // tbpImportarCadastro
            // 
            this.tbpImportarCadastro.Controls.Add(this.lblBarraProgresso);
            this.tbpImportarCadastro.Controls.Add(this.PbImportacao);
            this.tbpImportarCadastro.Controls.Add(this.btnImportarCadastro);
            this.tbpImportarCadastro.Location = new System.Drawing.Point(4, 28);
            this.tbpImportarCadastro.Name = "tbpImportarCadastro";
            this.tbpImportarCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpImportarCadastro.Size = new System.Drawing.Size(589, 365);
            this.tbpImportarCadastro.TabIndex = 0;
            this.tbpImportarCadastro.Text = "Importar Cadastro";
            this.tbpImportarCadastro.UseVisualStyleBackColor = true;
            // 
            // lblBarraProgresso
            // 
            this.lblBarraProgresso.AutoSize = true;
            this.lblBarraProgresso.Location = new System.Drawing.Point(9, 11);
            this.lblBarraProgresso.Name = "lblBarraProgresso";
            this.lblBarraProgresso.Size = new System.Drawing.Size(45, 19);
            this.lblBarraProgresso.TabIndex = 5;
            this.lblBarraProgresso.Text = "label1";
            // 
            // PbImportacao
            // 
            this.PbImportacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbImportacao.Location = new System.Drawing.Point(8, 30);
            this.PbImportacao.Name = "PbImportacao";
            this.PbImportacao.Size = new System.Drawing.Size(573, 23);
            this.PbImportacao.TabIndex = 4;
            // 
            // btnImportarCadastro
            // 
            this.btnImportarCadastro.Location = new System.Drawing.Point(225, 140);
            this.btnImportarCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportarCadastro.Name = "btnImportarCadastro";
            this.btnImportarCadastro.Size = new System.Drawing.Size(138, 53);
            this.btnImportarCadastro.TabIndex = 3;
            this.btnImportarCadastro.Text = "Importar Cadastro";
            this.btnImportarCadastro.UseVisualStyleBackColor = true;
            this.btnImportarCadastro.Click += new System.EventHandler(this.btnImportarCadastro_Click);
            // 
            // tbpFaturar
            // 
            this.tbpFaturar.Controls.Add(this.lblProgresso);
            this.tbpFaturar.Controls.Add(this.pbEnvioRps);
            this.tbpFaturar.Controls.Add(this.lblDescricaoServico);
            this.tbpFaturar.Controls.Add(this.btnRemoverSelecao);
            this.tbpFaturar.Controls.Add(this.btnSelecionarTodos);
            this.tbpFaturar.Controls.Add(this.txtObservacao);
            this.tbpFaturar.Controls.Add(this.btnImportarFaturamento);
            this.tbpFaturar.Controls.Add(this.dgvImportarFaturamento);
            this.tbpFaturar.Location = new System.Drawing.Point(4, 28);
            this.tbpFaturar.Name = "tbpFaturar";
            this.tbpFaturar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFaturar.Size = new System.Drawing.Size(589, 365);
            this.tbpFaturar.TabIndex = 1;
            this.tbpFaturar.Text = "Importar Rps";
            this.tbpFaturar.UseVisualStyleBackColor = true;
            // 
            // btnRemoverSelecao
            // 
            this.btnRemoverSelecao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverSelecao.Location = new System.Drawing.Point(102, 308);
            this.btnRemoverSelecao.Name = "btnRemoverSelecao";
            this.btnRemoverSelecao.Size = new System.Drawing.Size(87, 49);
            this.btnRemoverSelecao.TabIndex = 7;
            this.btnRemoverSelecao.Text = "Remover Seleção";
            this.btnRemoverSelecao.UseVisualStyleBackColor = true;
            this.btnRemoverSelecao.Click += new System.EventHandler(this.btnRemoverSelecao_Click);
            // 
            // btnSelecionarTodos
            // 
            this.btnSelecionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelecionarTodos.Location = new System.Drawing.Point(9, 308);
            this.btnSelecionarTodos.Name = "btnSelecionarTodos";
            this.btnSelecionarTodos.Size = new System.Drawing.Size(87, 49);
            this.btnSelecionarTodos.TabIndex = 6;
            this.btnSelecionarTodos.Text = "Selecionar Todos";
            this.btnSelecionarTodos.UseVisualStyleBackColor = true;
            this.btnSelecionarTodos.Click += new System.EventHandler(this.btnSelecionarTodos_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.Location = new System.Drawing.Point(8, 182);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(573, 99);
            this.txtObservacao.TabIndex = 5;
            // 
            // btnImportarFaturamento
            // 
            this.btnImportarFaturamento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImportarFaturamento.Location = new System.Drawing.Point(225, 308);
            this.btnImportarFaturamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportarFaturamento.Name = "btnImportarFaturamento";
            this.btnImportarFaturamento.Size = new System.Drawing.Size(138, 53);
            this.btnImportarFaturamento.TabIndex = 4;
            this.btnImportarFaturamento.Text = "Enviar Rps";
            this.btnImportarFaturamento.UseVisualStyleBackColor = true;
            this.btnImportarFaturamento.Click += new System.EventHandler(this.btnImportarFaturamento_Click);
            // 
            // dgvImportarFaturamento
            // 
            this.dgvImportarFaturamento.AllowUserToAddRows = false;
            this.dgvImportarFaturamento.AllowUserToDeleteRows = false;
            this.dgvImportarFaturamento.AllowUserToOrderColumns = true;
            this.dgvImportarFaturamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImportarFaturamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvImportarFaturamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportarFaturamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            this.dgvImportarFaturamento.Location = new System.Drawing.Point(7, 3);
            this.dgvImportarFaturamento.Name = "dgvImportarFaturamento";
            this.dgvImportarFaturamento.RowHeadersVisible = false;
            this.dgvImportarFaturamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportarFaturamento.Size = new System.Drawing.Size(574, 150);
            this.dgvImportarFaturamento.TabIndex = 0;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Width = 78;
            // 
            // lblDescricaoServico
            // 
            this.lblDescricaoServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescricaoServico.AutoSize = true;
            this.lblDescricaoServico.Location = new System.Drawing.Point(8, 160);
            this.lblDescricaoServico.Name = "lblDescricaoServico";
            this.lblDescricaoServico.Size = new System.Drawing.Size(176, 19);
            this.lblDescricaoServico.TabIndex = 8;
            this.lblDescricaoServico.Text = "Discriminação dos Serviços";
            // 
            // pbEnvioRps
            // 
            this.pbEnvioRps.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbEnvioRps.Location = new System.Drawing.Point(397, 325);
            this.pbEnvioRps.Name = "pbEnvioRps";
            this.pbEnvioRps.Size = new System.Drawing.Size(158, 23);
            this.pbEnvioRps.TabIndex = 9;
            // 
            // lblProgresso
            // 
            this.lblProgresso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.Location = new System.Drawing.Point(393, 303);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(73, 19);
            this.lblProgresso.TabIndex = 10;
            this.lblProgresso.Text = "Progresso:";
            // 
            // FrmImportarPlanilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 397);
            this.Controls.Add(this.tbcImportar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmImportarPlanilha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Planilha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmImportarPlanilha_FormClosing);
            this.tbcImportar.ResumeLayout(false);
            this.tbpImportarCadastro.ResumeLayout(false);
            this.tbpImportarCadastro.PerformLayout();
            this.tbpFaturar.ResumeLayout(false);
            this.tbpFaturar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportarFaturamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcImportar;
        private System.Windows.Forms.TabPage tbpImportarCadastro;
        private System.Windows.Forms.Label lblBarraProgresso;
        private System.Windows.Forms.ProgressBar PbImportacao;
        private System.Windows.Forms.Button btnImportarCadastro;
        private System.Windows.Forms.TabPage tbpFaturar;
        private System.Windows.Forms.DataGridView dgvImportarFaturamento;
        private System.Windows.Forms.Button btnImportarFaturamento;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnRemoverSelecao;
        private System.Windows.Forms.Button btnSelecionarTodos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.Label lblDescricaoServico;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.ProgressBar pbEnvioRps;

    }
}