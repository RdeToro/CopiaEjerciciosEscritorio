using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtCampoObligatorio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Hola");
            TextBox miTextBox = (TextBox)sender;
            if (string.IsNullOrEmpty(miTextBox.Text))
            {
                e.Cancel = true;
                string Mensaje = String.Format("El campo {0} es obligatorio", miTextBox.Text);
                errorProvider1.SetError(miTextBox, Mensaje);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(miTextBox, String.Empty);
            }
        }
    }
}
