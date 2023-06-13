namespace ProyectoICPPropio
{
    public partial class Form1 : Form
    {
        ConsultarAvisos avisos { get; set; }
        InsertarAvisoReferencias AvisoReferencias {get; set; }
        public Form1() 
        {
            InitializeComponent();
            avisos = new ConsultarAvisos();
            AvisoReferencias = new InsertarAvisoReferencias();  
        }

        private void lblInsertarAviso_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvisoReferencias.Show();
        }

        private void btnVerAvisos_Click(object sender, EventArgs e)
        {
            this.Hide();
            avisos.Show();
        }
    }
}