namespace Ejemplo_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show(String.Format("El campo {0} es obligatorio", txtNombre.Tag));
                e.Cancel = true;
                string mensaje = String.Format("El campo {0} es obligatorio", txtNombre.Tag);
                errorProvider1.SetError(txtNombre, mensaje);

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtApellidos_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show(String.Format("El campo {0} es obligatorio", txtApellidos.Tag));
                e.Cancel = true;
                string mensaje = String.Format("El campo {0} es obligatorio", txtApellidos.Tag);
                errorProvider1.SetError(txtApellidos, mensaje);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtApellidos, "");
            }
        }
    }
}