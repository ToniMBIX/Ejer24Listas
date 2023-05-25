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
    public partial class FormItem : Form
    {
        public string InputText { get; private set; }
        public FormItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputText = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
