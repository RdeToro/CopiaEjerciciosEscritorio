using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace Ejemplo_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadenaConexion = @"Server = localhost\SQLEXPRESS; Database = AuditoriasCentros; Trusted_Connection = True;";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if(conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }

                }
                



                conexion.Close();
            }
        }
    }
}