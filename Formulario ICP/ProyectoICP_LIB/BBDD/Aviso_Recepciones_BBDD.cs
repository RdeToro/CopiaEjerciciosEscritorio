using ConexionBBDD_LIB;
using ProyectoICP_LIB.NEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConexionBBDD_LIB.ParametroBBDD;

namespace ProyectoICP_LIB.BBDD
{
    public class Aviso_Recepciones_BBDD
    {
        ConexionBBDD _conexion = new ConexionBBDD(Utilidades.CadenaConexion);

        public DataTable LeerCAB()
        {
            string SQL = "SELECT * FROM dbo.AVISO_RECEPCIONES_CAB";

            bool bResultado = false;
            DataTable resultado = null;

            bResultado = _conexion.Abrir();
            resultado = new DataTable();

            if (bResultado)
            {             

                resultado = _conexion.LeerDatos(SQL);

                

            }
            bResultado = _conexion.Cerrar();
            return resultado;


        }

        public DataTable LeerCAB(int ID_AVISO_RECEPCION)
        {
            bool bResultado = false;
            List<ParametroBBDD> parametros = null;
            DataTable resultado = null;
            string SQL = "SELECT * FROM dbo.AVISO_RECEPCIONES_CAB WHERE ID_AVISO_RECEPCION = @ID_AVISO_RECEPCION";

            parametros = new List<ParametroBBDD> 
            {
                new ParametroBBDD
                {
                    Nombre = "ID_AVISO_RECEPCION",
                    Tipo = DbType.Int32,
                    Direccion = TipoDireccion.Entrada,
                    Valor = ID_AVISO_RECEPCION
                }
            };

            bResultado = _conexion.Abrir();

            if(bResultado)
            {
                resultado = _conexion.LeerDatos(SQL,parametros);

            }

            return resultado;
            bResultado= _conexion.Cerrar();           


        }

        public int Insertar(Aviso_Recepciones_CAB_NEG Cab, DataTable LIN)
        {
            List<ParametroBBDD> parametros = new List<ParametroBBDD>();
            int resultado = 0;

            if (LIN.Rows.Count > 0 && LIN != null)
            {
                
                ParametroBBDD parametro = new ParametroBBDD
                {
                    Nombre = "ESTADO_AVISO",
                    Tipo = DbType.Byte,
                    Valor = Cab.ESTADO_AVISO,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "COD_PEDIDO",
                    Tipo = DbType.String,
                    Valor = Cab.COD_PEDIDO,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "ID_PROVEEDOR",
                    Tipo = DbType.Int32,
                    Valor = Cab.ID_PROVEEDOR,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "TIPO_AVISO",
                    Tipo = DbType.Byte,
                    Valor = Cab.TIPO_AVISO,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "AVISO_LIN",
                    Tipo = DbType.Object,
                    Valor = LIN,
                    Direccion = TipoDireccion.Entrada,
                    TipoSQL = SqlDbType.Structured
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "RETCODE",
                    Tipo = DbType.Int32,
                    Direccion = TipoDireccion.EntradaSalida
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "MENSAJE",
                    Tipo = DbType.String,
                    Direccion = TipoDireccion.EntradaSalida
                };

                parametros.Add(parametro);
            }

            string SQL = "dbo.PA_INSERTAR_AVISO_RECEPCION";
            resultado = _conexion.Ejecutar(SQL, parametros);

            return resultado;
            
        }

        

    }
}
