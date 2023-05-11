/*
 * Programa que va a seleccionar una carpeta del disco y va a cargar los ficheros de la misma en 
 * una caja de texto para poderlos copiar al final.
 * Se mostrara una barra de progreso en la barra de estado del formaulario para ver como avanza, 
 * a la vez que se escriben los ficheros cargados en la barra de texto.
*/
using System.Text;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        private string[] _ficheros;
        private StringBuilder _sb;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = folderBrowserDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                txtCarpeta.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void txtCarpeta_TextChanged(object sender, EventArgs e)
        {
            if (txtCarpeta.Text.Trim().Length > 0)
            {
                btnCargarFicheros.Enabled = true;
            }
        }

        private void btnCargarFicheros_Click(object sender, EventArgs e)
        {
            _ficheros = Directory.GetFiles(txtCarpeta.Text);
            ProgressBar1.Minimum = 0;
            ProgressBar1.Maximum = _ficheros.Length;
            ProgressBar1.Step = 1;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _sb = new StringBuilder();
            for (int i = 1; i < _ficheros.Length; i++)
            {
                FileInfo miFichero = new FileInfo(_ficheros[i]);
                _sb.AppendLine(miFichero.Name);
                backgroundWorker1.ReportProgress(i + 1);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            txtFicheros.Text = _sb.ToString();
            ProgressBar1.Value = e.ProgressPercentage;
            lblProgreso.Text = e.ProgressPercentage.ToString() + "/" + _ficheros.Length;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Proceso finalizado", "Carga Ficheros", MessageBoxButtons.OK);

        }
    }
}