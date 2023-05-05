using Biblioteca;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms.Design;

namespace Ejemplo_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<Pais> lstPais = new List<Pais>();
            //string cadenaConexion = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AuditoriasCentros;Data Source=localhost\\SQLEXPRESS";

            string cadenaConexion = @"File Name= C:\KK\KK2\conexion.udl";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                OleDbCommand comand = conexion.CreateCommand();
                string SQL = "SELECT Id,Codigo,Nombre FROM Tabla_Pais WHERE CODIGO = ?";
                
                OleDbParameter parametro = new OleDbParameter("@Codigo",DbType.String);
                parametro.Value = "ES";

                comand.Parameters.Add(parametro);

                comand.CommandText = SQL;

                OleDbDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Pais temp = new Pais
                    {
                        Id = (int)reader["Id"],
                        Codigo = (string)reader["Codigo"],
                        Nombre = (string)reader["Nombre"]

                    };
                    lstPais.Add(temp);
                }
                conexion.Close();
            }

            dgvPaises.DataSource = lstPais;
        }
    }

}

