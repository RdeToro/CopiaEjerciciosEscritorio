namespace ProyectoICPPropio
{
    public partial class Form1 : Form
    {
        public InsertarAvisoReferencias AvisoReferencias { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void lblInsertarAviso_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvisoReferencias.ShowDialog();
        }
    }
}