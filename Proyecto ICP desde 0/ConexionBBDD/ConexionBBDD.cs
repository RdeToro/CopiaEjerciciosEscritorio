using System.Data.SqlClient;
using System.Data;

namespace ConexionBBDD
{
    public class ConexionBBDD
    {
        private string _CadenaConexion;
        public SqlConnection Conexion { get; set; }
        public SqlTransaction Transaccion { get; set; }

        public SqlParameter Parametros { get; set; }

        public ConexionBBDD(string CadenaConexion)
        {
            _CadenaConexion = CadenaConexion;
        }

        public bool Abrir ()
        {
            bool bResultado = false;
            Conexion = new SqlConnection (_CadenaConexion);
            Conexion.Open ();

            if(Conexion.State == ConnectionState.Open )
                bResultado = true;

            return bResultado;

        }

        public bool Cerrar()
        {
            bool bResultado = false;
            Conexion.Close ();

            if(Conexion.State == ConnectionState.Closed )
                bResultado = true;

            return bResultado;
        }

        public DataTable Leer(string Sql)
        {
            DataTable resultado = null;
            if(Conexion.State == ConnectionState .Open )
            {
                SqlCommand cmd = Conexion.CreateCommand ();
                
                cmd.CommandText = Sql;

                SqlDataReader reader = cmd.ExecuteReader ();

                resultado.Load(reader);

                
            }
            return resultado;
        
        }

        public int Escribir (string SQL, List<Parametro> parametros) 
        {
            SqlCommand comando = Conexion.CreateCommand ();
            comando.CommandText = SQL;

            int resultado = 0;
            
            if(parametros != null && Conexion.State == ConnectionState.Open)
            {

                foreach(Parametro param in parametros)
                {
                    Parametros.ParameterName = String.Format("@" + param.Nombre);
                    Parametros.DbType = param.Tipo;
                    Parametros.Value = param.Valor;

                    if(param.Direccion == Parametro.Direction.Entrada)
                    {
                        Parametros.Direction = ParameterDirection.Input;
                    }
                    else if (param.Direccion == Parametro.Direction.Salida)
                    {
                        Parametros.Direction = ParameterDirection.Output;
                    }
                    else if(param.Direccion == Parametro.Direction.EntradaSalida)
                    {
                        Parametros.Direction = ParameterDirection.InputOutput;
                    }

                    comando.Parameters.Add(param);
                    
                    comando.ExecuteNonQuery ();

                    SQL = "Select @@Identity";


                    comando = new SqlCommand(SQL);

                    SqlDataReader reader = comando.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    
                    if(reader != null)
                    {
                        dataTable.Load(reader);
                        resultado = Convert.ToInt32(dataTable.Rows[0][0]);
                    }
                    
                   
                }

                 
            }
            return resultado;
        }

    }
}