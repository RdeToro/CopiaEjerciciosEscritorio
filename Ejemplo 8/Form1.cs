namespace Ejemplo_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            miPrimerControl1.FechaCambiada += LaFechaCambiaEnElControl;
            miPrimerControl2.FechaCambiada += LaFechaCambiaEnElControl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Fecha1 = miPrimerControl1.FechaInicio;
            DateTime Fecha2 = miPrimerControl1.FechaFin;

            DateTime Fech1 = miPrimerControl2.FechaInicio;
            DateTime Fech2 = miPrimerControl2.FechaFin;
        }

        private void LaFechaCambiaEnElControl(object sender, EventArgs e)
        {
            MiPrimerControl control = (MiPrimerControl)sender;
            MessageBox.Show(control.FechaInicio.ToShortDateString());

        }
    }
}