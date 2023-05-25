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
    public partial class FormManejoFormatos : Form
    {
        Label myLabel;
        public FormManejoFormatos()
        {
            InitializeComponent();
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            myLabel = this.labelEtiqueta;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            this.negritaToolStripMenuItem.Click += new System.EventHandler(this.negritaToolStripMenuItem_Click);
            this.cursivaToolStripMenuItem.Click += new System.EventHandler(this.cursivaToolStripMenuItem_Click);
            this.subrayadoToolStripMenuItem.Click += new System.EventHandler(this.subrayadoToolStripMenuItem_Click);
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.arialToolStripMenuItem_Click);
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click);
            this.courierNewToolStripMenuItem.Click += new System.EventHandler(this.courierNewToolStripMenuItem_Click);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int newSize = 12;
            myLabel.Font = new Font(myLabel.Font.FontFamily, newSize, myLabel.Font.Style);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int newSize = 14;
            myLabel.Font = new Font(myLabel.Font.FontFamily, newSize, myLabel.Font.Style);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int newSize = 16;
            myLabel.Font = new Font(myLabel.Font.FontFamily, newSize, myLabel.Font.Style);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int newSize = 18;
            myLabel.Font = new Font(myLabel.Font.FontFamily, newSize, myLabel.Font.Style);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            int newSize = 20;
            myLabel.Font = new Font(myLabel.Font.FontFamily, newSize, myLabel.Font.Style);
        }

        private void toolStripButtonNegrita_Click(object sender, EventArgs e)
        {
            labelEtiqueta.Font = new Font(labelEtiqueta.Font, FontStyle.Bold);
        }

        private void toolStripButtonCursiva_Click(object sender, EventArgs e)
        {
            labelEtiqueta.Font = new Font(labelEtiqueta.Font, FontStyle.Italic);
        }

        private void toolStripButtonSubrayado_Click(object sender, EventArgs e)
        {
            labelEtiqueta.Font = new Font(labelEtiqueta.Font, FontStyle.Underline);
        }

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonNegrita.PerformClick();
        }

        private void cursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonCursiva.PerformClick();
        }

        private void subrayadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonSubrayado.PerformClick();
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelEtiqueta.Font = new Font("Arial", labelEtiqueta.Font.Size, labelEtiqueta.Font.Style);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelEtiqueta.Font = new Font("Times New Roman", labelEtiqueta.Font.Size, labelEtiqueta.Font.Style);
        }

        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelEtiqueta.Font = new Font("Courier New", labelEtiqueta.Font.Size, labelEtiqueta.Font.Style);
        }
    }
}
