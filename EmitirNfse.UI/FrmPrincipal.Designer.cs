namespace EmitirNfse.UI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protocolosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarPlanilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaFiscalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // notaFiscalToolStripMenuItem
            // 
            this.notaFiscalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.emitirNotaFiscalToolStripMenuItem,
            this.protocolosToolStripMenuItem,
            this.importarPlanilhaToolStripMenuItem});
            this.notaFiscalToolStripMenuItem.Name = "notaFiscalToolStripMenuItem";
            this.notaFiscalToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.notaFiscalToolStripMenuItem.Text = "Nota Fiscal";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // emitirNotaFiscalToolStripMenuItem
            // 
            this.emitirNotaFiscalToolStripMenuItem.Name = "emitirNotaFiscalToolStripMenuItem";
            this.emitirNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.emitirNotaFiscalToolStripMenuItem.Text = "Emitir Nota Fiscal";
            this.emitirNotaFiscalToolStripMenuItem.Click += new System.EventHandler(this.emitirNotaFiscalToolStripMenuItem_Click);
            // 
            // protocolosToolStripMenuItem
            // 
            this.protocolosToolStripMenuItem.Name = "protocolosToolStripMenuItem";
            this.protocolosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.protocolosToolStripMenuItem.Text = "Protocolos";
            this.protocolosToolStripMenuItem.Click += new System.EventHandler(this.protocolosToolStripMenuItem_Click);
            // 
            // importarPlanilhaToolStripMenuItem
            // 
            this.importarPlanilhaToolStripMenuItem.Name = "importarPlanilhaToolStripMenuItem";
            this.importarPlanilhaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importarPlanilhaToolStripMenuItem.Text = "Importar Planilha";
            this.importarPlanilhaToolStripMenuItem.Click += new System.EventHandler(this.importarPlanilhaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem notaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem protocolosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarPlanilhaToolStripMenuItem;
    }
}

