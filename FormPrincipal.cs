using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer24Listas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.fORMATOSToolStripMenuItem.Click += new System.EventHandler(this.fORMATOSToolStripMenuItem_Click);

        }

        private void fORMATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManejoFormatos formManejoFormatos = new FormManejoFormatos();
            formManejoFormatos.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lISTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManejoListas formManejoListas = new FormManejoListas();
            formManejoListas.Show();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.O)
            {
                toolStripMenuItem1.ShowDropDown();
                return true;
            }
            if (keyData == Keys.S)
            {
                toolStripMenuItem2.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
