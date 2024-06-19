using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

namespace EmitirNfse.UI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void emitirNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmitirNfse frm = new FrmEmitirNfse();
            frm.frmNotaFiscal_Closing += new EventHandler(HabilitarMenuNota);
            frm.MdiParent = this;
            frm.Show();
            emitirNotaFiscalToolStripMenuItem.Enabled = false;
        }

        private void HabilitarMenuNota(object sender, EventArgs e)
        {
            emitirNotaFiscalToolStripMenuItem.Enabled = true;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.frmCliente_Closing += new EventHandler(HabilitarMenuCliente);
            frm.MdiParent = this;
            frm.Show();
            clientesToolStripMenuItem.Enabled = false;
        }

        private void HabilitarMenuCliente(object sender, EventArgs e)
        {
            clientesToolStripMenuItem.Enabled = true;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(ConfigurationManager.AppSettings["CaminhoArquivos"].ToString()))
                System.IO.Directory.CreateDirectory(ConfigurationManager.AppSettings["CaminhoArquivos"].ToString());
            if (!System.IO.Directory.Exists(@"C:\Temp\ErroImportarFaturamento"))
                System.IO.Directory.CreateDirectory(@"C:\Temp\ErroImportarFaturamento");

        }

        private void protocolosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProtocolos frm = new FrmProtocolos();
            frm.FrmProtocolos_Closing += new EventHandler(HabilitarMenuProtocolo);
            frm.MdiParent = this;
            frm.Show();
            protocolosToolStripMenuItem.Enabled = false;
        }

        private void HabilitarMenuProtocolo(object sender, EventArgs e)
        {
            protocolosToolStripMenuItem.Enabled = true;
        }

        private void importarPlanilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportarPlanilha frm = new FrmImportarPlanilha();
            frm.FrmImport_Closing += new EventHandler(HabilitarMenuImportar);
            frm.MdiParent = this;
            frm.Show();
            importarPlanilhaToolStripMenuItem.Enabled = false;
        }

        private void HabilitarMenuImportar(object sender, EventArgs e)
        {
            importarPlanilhaToolStripMenuItem.Enabled = true;
        }
    }
}
