using PROCEDIMIENTOS_LIB.Negocio;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCEDIMIENTOS_LIB.Datos
{
    public class AvisoRecepcionesCab_Lin_Datos
    {

        public AvisoRecepcionesCAB MICAB { get; set; }
        public List<AvisoRecepcionesLIN> MILIN { get; set; }
        private string _CadenaConexion;
        public bool EstadoConexion { get; set; }

        public List<PARAMETRO> Parametros { get; set; }

        public AvisoRecepcionesCab_Lin_Datos(string CadenaConexion, AvisoRecepcionesCAB mICAB, List<AvisoRecepcionesLIN> mILIN)
        {
            _CadenaConexion = CadenaConexion;
            MICAB = mICAB;
            MILIN = mILIN;

        }
        public List<AvisoRecepcionesCAB> MisRecepcionesCAB { get; set; }


        public List<AvisoRecepcionesCAB> LeerCABBBDD()
        {
            
            SqlConnection sqlConnection = new SqlConnection(_CadenaConexion);
            List<AvisoRecepcionesCAB> resultado = null;
            DataTable tabla = null;
            bool Conexion = false;

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                Conexion = true;



                string sql = "SELECT ID_AVISO_RECEPCION," +
                                     "FECHA_INSERT," +
                                     "ESTADO_AVISO," +
                                     "COD_PEDIDO," +
                                     "ID_PROVEEDOR," +
                                     "TIPO_AVISO" +
                                     "FROM AVISO_RECEPCIONES_CAB";
                SqlCommand comando = sqlConnection.CreateCommand();
                comando.CommandText = sql;

                SqlDataReader leido = comando.ExecuteReader();

                if (leido != null)
                {
                    tabla = new DataTable();
                    tabla.Load(leido);

                    while (leido.Read())
                    {
                        AvisoRecepcionesCAB cAB = null;
                        cAB = new AvisoRecepcionesCAB
                        {
                            Id_Aviso_Recepciones = Convert.ToInt32(leido["ID_AVISO_RECEPCION"]),
                            Fecha = Convert.ToDateTime(leido["FECHA_INSERT"]),
                            ESTADO_AVISO = Convert.ToInt16(leido["ESTADO_AVISO"]),
                            COD_PEDIDO = leido["COD_PEDIDO"].ToString(),
                            ID_PROVEEDOR = Convert.ToInt32(leido["ID_PROVEEDOR"]),
                            TIPO_AVISO = Convert.ToInt16(leido["TIPO_AVISO"])
                        };
                        resultado.Add(cAB);
                    }
                }
                else
                    Conexion = false;

            }
            return resultado;
        }

        //public int EscribirBBDD()
        //{
            
        //    SqlConnection conexion = new SqlConnection(_CadenaConexion);

        //    string sql = "EXEC PA_AVISO_RECEPCIONES_CAB_LIN @ESTADO_AVISO, @COD_PEDIDO, @ID_PROVEDOR," +
        //                                                    "@TIPO_AVISO, @REFERENCIA, @RETCODE OUTPUT, " +
        //                                                    "@MENSAJE OUTPUT";

        //    SqlCommand comando = conexion.CreateCommand();
        //    comando.CommandText = sql;

        //    SqlParameter Parametro = new SqlParameter();
        //    Parametro.ParameterName = "@ESTADO_AVISO";
        //    Parametro.DbType = DbType.Int16;
        //    Parametro.Value = avisoCAB.ESTADO_AVISO.ToString();

        //    comando.Parameters.Add(Parametro);

        //    Parametro = new SqlParameter();
        //    Parametro.ParameterName = "@COD_PEDIDO";
        //    Parametro.DbType = DbType.String;
        //    Parametro.Value = avisoCAB.COD_PEDIDO;

        //    comando.Parameters.Add(Parametro);

        //    Parametro = new SqlParameter();
        //    Parametro.ParameterName = "@ID_PROVEDOR";
        //    Parametro.DbType = DbType.Int32;
        //    Parametro.Value = avisoCAB.ID_PROVEEDOR.ToString();

        //    comando.Parameters.Add(Parametro);

        //    Parametro = new SqlParameter();
        //    Parametro.ParameterName = "@TIPO_AVISO";
        //    Parametro.DbType = DbType.Int16;
        //    Parametro.Value = avisoCAB.TIPO_AVISO.ToString();

        //    comando.Parameters.Add(Parametro);

        //    Parametro = new SqlParameter();
        //    Parametro.ParameterName = "@REFERENCIA";
        //    Parametro.DbType = DbType.String;
        //    Parametro.Value = avisoLIN;

        //    comando.Parameters.Add(Parametro);




        //}



    }
}
