using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;
using static ConexionBBDD_LIB.ParametroBBDD;

namespace ConexionBBDD_LIB
{
    public class ConexionBBDD
    {
        public string cadenaConexion { get; set; }

        public SqlConnection conexion { get; set; }

        public SqlTransaction Transaccion { get; set; }

        public ConexionBBDD(string Cadena)
        {
            cadenaConexion = Cadena;
        }

        public bool Abrir()
        {
            conexion = new SqlConnection(cadenaConexion);
            bool bResultado = false;
            conexion.Open();
            if (conexion.State == ConnectionState.Open)
            {              
                bResultado = true;
               
            }
            
            return bResultado;

        }

        public bool Cerrar()
        {
            bool bResultado = false;
            conexion.Close();

            if (conexion.State == ConnectionState.Closed)
            {
                bResultado = true;
            }
            return bResultado;
        }

        public DataTable LeerDatos(string SQL, List<ParametroBBDD> parametros = null)
        {
            DataTable resultado = null;
            if (conexion.State == ConnectionState.Open)
            {
                SqlCommand comando = conexion.CreateCommand();
                                
                comando.CommandText = SQL;

                if (parametros != null)
                {
                    for (int i = 0; i < parametros.Count; i++)
                    {
                        SqlParameter parametro = new SqlParameter();
                        parametro.ParameterName = String.Format("@{0}",parametros[i].Nombre);
                        parametro.DbType = parametros[i].Tipo;
                        parametro.Value = parametros[i].Valor;
                        if (parametros[i].Tamanho != null)
                            parametro.Size = parametros[i].Tamanho;
                        if (parametros[i].Direccion == TipoDireccion.EntradaSalida)
                            parametro.Direction = ParameterDirection.InputOutput;

                        comando.Parameters.Add(parametro);
                    }
                }

                SqlDataReader reader = comando.ExecuteReader();

                if (reader != null)
                {
                    resultado = new DataTable();
                    resultado.Load(reader);
                }
            }
            return resultado;
        }

        public int Ejecutar(string SQL, List<ParametroBBDD> parametros = null)
        {
            int resultado =0;
            if (conexion.State == ConnectionState.Open)
            {
                SqlCommand comando = conexion.CreateCommand();

                comando.CommandText = SQL;

                if (SQL.Trim().Split('_')[0].ToLower() == "dbo.PA".ToLower())
                    comando.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    for (int i = 0; i < parametros.Count; i++)
                    {
                        SqlParameter parametro = new SqlParameter();
                        parametro.ParameterName =  String.Format("@{0}",parametros[i].Nombre);
                        parametro.DbType = parametros[i].Tipo;
                        parametro.Value = parametros[i].Valor;
                        if (parametros[i].Tamanho != null)
                            parametro.Size = parametros[i].Tamanho;

                        if (parametros[i].Direccion == TipoDireccion.Entrada)
                        {
                            parametro.Direction = ParameterDirection.Input;
                        }
                            
                        else if (parametros[i].Direccion ==TipoDireccion.Salida)
                        {
                            parametro.Direction = ParameterDirection.Output;
                        }
                        else if (parametros[i].Direccion == TipoDireccion.EntradaSalida)
                        {
                            parametro.Direction= ParameterDirection.InputOutput;
                        }
                        if (parametros[i].TipoSQL !=  null && parametros[i].TipoSQL == SqlDbType.Structured)
                        {
                            parametro.SqlDbType = parametros[i].TipoSQL;
                            parametro.TypeName = "dbo.TI_INSERTAR_AVISO_LIN2";
                        }


                        comando.Parameters.Add(parametro);
                    }
                }
                resultado = comando.ExecuteNonQuery();
            }
            return resultado;
        }

        public void IniciarTrans()
        {
            if (conexion.State == ConnectionState.Open)
                Transaccion = conexion.BeginTransaction();
            
        }

        public void CommitTrans()
        {
            if (conexion.State == ConnectionState.Open)
                Transaccion.Commit();
        }

        public void RollBackTrans()
        {
            if (conexion.State == ConnectionState.Open)
                Transaccion.Rollback();
        }
    }
}