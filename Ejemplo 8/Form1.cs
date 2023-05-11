namespace Ejemplo_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            miPrimerControl1.FechaCambiada += LaFechaCambiaEnElControl;
            miPrimerControl1.MeCagoEnTusMuelas += ReciboLaCagadaEnSusMuelas;

            miPrimerControl2.FechaCambiada += LaFechaCambiaEnElControl;
            miPrimerControl2.MeCagoEnTusMuelas += ReciboLaCagadaEnSusMuelas;
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
            if (control.Tag == "MiPrimeritoControl1")
            {

                txtFecha1.Text = String.Format("{0} - {1}",
                                            control.FechaInicio.ToShortDateString(),
                                            control.FechaFin.ToShortDateString());

            }

            if(control.Tag == "MiPrimeritoControl2")
            {
                txtFecha2.Text = String.Format("{0} - {1}",
                                            control.FechaInicio.ToShortDateString(),
                                            control.FechaFin.ToShortDateString());
            }
        }

        private void ReciboLaCagadaEnSusMuelas(object sender, MeCagoEnTusMuelasEventArgs e)
        {
            MiPrimerControl control = (MiPrimerControl)sender;
            string texto = String.Format("El control {0} tiene {1} muelas de color {2}", control.Tag, e.NumeroDeMuelas, e.ColorDeLasMuelas);
            MessageBox.Show(texto);
        }
    }
}