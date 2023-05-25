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
    public partial class FormManejoListas : Form
    {
        public FormManejoListas()
        {
            InitializeComponent();
            contextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip_ItemClicked);
        }
        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Añadir":
                    FormItem formItem = new FormItem();
                    formItem.ShowDialog();
                    if (formItem.DialogResult == DialogResult.OK)
                    {
                        listBox1.Items.Add(formItem.InputText);
                    }
                    break;
                case "Eliminar seleccionado":
                    if (listBox1.SelectedItem != null)
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                    }
                    break;
                case "Eliminar todo":
                    listBox1.Items.Clear();
                    break;
                case "Salir":
                    this.Close();
                    break;
            }
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

    }
}
