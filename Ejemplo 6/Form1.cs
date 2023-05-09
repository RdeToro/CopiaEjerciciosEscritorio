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
                SqlTransaction transaccion = null;
                try
                {
                    conexion.Open();

                    transaccion = conexion.BeginTransaction();


                    SqlCommand comando = conexion.CreateCommand();
                    comando.CommandText = "SELECT Nombre,PoblacionId,Direccion,CP FROM Tabla_Centro WHERE Nombre LIKE @Nombre AND ID = @CentroId";
                    
                    SqlParameter parametro = new SqlParameter("@CentroId",SqlDbType.BigInt);
                    parametro.Value = 2;
                    comando.Parameters.Add(parametro);

                    parametro =  new SqlParameter("@Nombre",SqlDbType.VarChar);
                    parametro.Value = "%Guadalajara";
                    comando.Parameters.Add(parametro);

                    

                    SqlDataReader reader = comando.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    var pipo = from x in dt.AsEnumerable()
                               select x;

                    /*
                    long ID;
                    int CP, PoblacionID;
                    string  Nombre, Direccion;

                    while (reader.Read())
                    {
                        ID = Convert.ToInt64(reader["Id"]);
                        Nombre = reader["Nombre"].ToString();
                        PoblacionID = Convert.ToInt32(reader["PoblacionId"]);
                        Direccion = reader["Direccion"].ToString();
                        CP = Convert.ToInt32(reader["CP"]);
                    }
                    */
                    transaccion.Commit();

                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
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