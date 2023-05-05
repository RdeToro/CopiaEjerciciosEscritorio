using _LIBGeoClases.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            List<Pais> lstPaises = new List<Pais>();

            //string cadenaConexion = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AuditoriasCentros;Data Source=fernando-laptop\\sqlexpress";
            string cadenaConexion = @"File Name= C:\kk\kk2\pipo.udl";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                conexion.Open();

                OleDbCommand comando = conexion.CreateCommand();
                string SQL = "SELECT Id, Codigo, Nombre FROM Tabla_Pais WHERE Id = ? OR Codigo = ?";

                OleDbParameter parametro = new OleDbParameter("@Id", DbType.Int32);
                parametro.Value = 5;

                comando.Parameters.Add(parametro);

                OleDbParameter parametro2 = new OleDbParameter("@Codigo", DbType.String);
                parametro2.Value = "ES";

                comando.Parameters.Add(parametro2);

                comando.CommandText = SQL;

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Pais temp = new Pais
                    {
                        Id = (int)reader["Id"],
                        Codigo = (string)reader["Codigo"],
                        Nombre = (string)reader["Nombre"]
                    };

                    lstPaises.Add(temp);
                }

                conexion.Close();
            }

            dgvPaises.DataSource = lstPaises;
        }
    }
}
