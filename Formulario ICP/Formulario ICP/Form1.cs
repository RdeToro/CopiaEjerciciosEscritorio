namespace Formulario_ICP
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos Productos = new Productos();
            Productos.Show();
        }
    }
}