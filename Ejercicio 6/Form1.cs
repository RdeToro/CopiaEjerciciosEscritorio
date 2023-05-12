namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal pantallaPrincipal = new FormPrincipal();
            pantallaPrincipal.Show();
        }
    }
}