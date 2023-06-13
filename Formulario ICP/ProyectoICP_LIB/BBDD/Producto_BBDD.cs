using ConexionBBDD_LIB;
using Microsoft.Data.SqlClient;
using ProyectoICP_LIB.NEGOCIO;
using System.Data;
using System.Drawing;
using static ConexionBBDD_LIB.ParametroBBDD;

namespace ProyectoICP_LIB.BBDD
{
    public class Producto_BBDD
    {
        private ConexionBBDD _conexion;

        public Producto_BBDD(string cadenaConexion)
        {
            _conexion = new ConexionBBDD(cadenaConexion);
        }

        public List<Producto_NEG> LeerProductos(int ProductoID)
        {
            List<Producto_NEG> resultado = null;
            DataTable datos = null;

            string SQL = "SELECT ID_REFERENCIA " +
                        ",F_INSERT " +
                        ",COD_REFERENCIA " +
                        ",DES_REFERENCIA" +
                        ",REF_CLIENTE " +
                        ",CODIGO_EAN  " +
                        ",ID_GRUPO  " +
                        ",CNT_ESTANDAR" +
                        ",PESO" +
                        ",OPERATIVA" +
                        ",LONGITUD_NSERIE" +
                        "FROM REFERENCIAS" +
                        "WHERE ID_REFERENCIA = @ReferenciaId";


            bool bResultado = _conexion.Abrir();

            

            if (bResultado)
            {
                List<ParametroBBDD> parametros = new List<ParametroBBDD>();
                ParametroBBDD parametro = new ParametroBBDD
                {
                    Nombre = "@ReferenciaId",
                    Tipo = DbType.Int32,
                    Valor = ProductoID                    
                };

                datos = _conexion.LeerDatos(SQL);
                resultado = new List<Producto_NEG>();

                foreach (DataRow row in datos.Rows)
                {
                    Producto_NEG producto = new Producto_NEG
                    {
                        Id = Convert.ToInt32(row["ID_REFERENCIA"]),
                        FechaCreacion = Convert.ToDateTime(row["F_IN"]),
                        CodReferencia = row["COD_REFERENCIA"].ToString(),
                        Descripcion = row["DES_REFERENCIA"].ToString(),
                        RefCliente = row["REF_CLIENTE"].ToString(),
                        CodEan = row["CODIGO_EAN"]==DBNull.Value ? null: row["CODIGO_EAN"].ToString(),
                        GrupoID = row["ID_GRUPO"] == DBNull.Value ? null : row["ID_GRUPO"].ToString(),
                        CantidadSTD = row["CNT_ESTANDAR"] == DBNull.Value ? 0 : Convert.ToInt32(row["CNT_ESTANDAR"]),
                        Peso = Convert.ToInt32(row["PESO"]),
                        Operativa = Convert.ToBoolean(row["OPERATIVA"]),
                        LongNUmSerie = Convert.ToInt32(row["LONGITUD_NSERIE"])
                    };
                    resultado.Add(producto);
                }

            }
            _conexion.Cerrar();

            return resultado;
        }


        public List<Producto_NEG> LeerProductos()
        {
            List<Producto_NEG> resultado = null;
            DataTable datos = null;

            string SQL = "SELECT ID_REFERENCIA " +
                        ",F_INSERT " +  
                        ",COD_REFERENCIA " +
                        ",DES_REFERENCIA" +    
                        ",REF_CLIENTE " +    
                        ",CODIGO_EAN  "  + 
                        ",ID_GRUPO  "  +
                        ",CNT_ESTANDAR"  +
                        ",PESO" +
                        ",OPERATIVA" +
                        ",LONGITUD_NSERIE" +
                        "FROM REFERENCIAS";

            bool bResultado = _conexion.Abrir();

            datos =_conexion.LeerDatos(SQL);

            if (datos != null)
            {
                resultado = new List<Producto_NEG>();

                foreach (DataRow row in datos.Rows)
                {
                    Producto_NEG producto = new Producto_NEG
                    {
                        Id = Convert.ToInt32(row["ID_REFERENCIA"]),
                        FechaCreacion = Convert.ToDateTime(row["F_IN"]),
                        CodReferencia = row["COD_REFERENCIA"].ToString(),
                        Descripcion = row["DES_REFERENCIA"].ToString(),
                        RefCliente = row["REF_CLIENTE"].ToString(),
                        CodEan = row["CODIGO_EAN"].ToString(),
                        GrupoID = row["ID_GRUPO"].ToString(),
                        CantidadSTD = Convert.ToInt32(row["CNT_ESTANDAR"]),
                        Peso = Convert.ToInt32(row["PESO"]),
                        Operativa = Convert.ToBoolean(row["OPERATIVA"]),
                        LongNUmSerie = Convert.ToInt32(row["LONGITUD_NSERIE"])
                    };
                    resultado.Add(producto);
                }
                
            }
            _conexion.Cerrar();

            return resultado;
        }

        public int Insertar(Producto_NEG producto)
        {
            string SQL = "PA_INSERTAR_REFERENCIA" +
                         "@CodReferencia, " +
                         "@DesReferencia, " +
                         "@RefCliente, " +
                         "@CodEAN, " +
                         "@GrupoId, " +
                         "@Cantidad, " +
                         "@Peso," +
                         "@Operativa," +
                         "@LonNumSerie," +
                         "@RETCODE OUTPUT, " +
                         "@MENSAJE OUTPUT";
            bool bResultado = _conexion.Abrir();
            int iResultado = 0;
            if (bResultado)
            {
                
                List<ParametroBBDD> parametros = new List<ParametroBBDD>();
                ParametroBBDD parametro = new ParametroBBDD               
                {
                    Nombre = "@CodReferencia",
                    Tipo = DbType.String,
                    Valor = producto.CodReferencia,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "@DesReferencia",
                    Tipo = DbType.String,
                    Valor = producto.Descripcion,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "@RefCliente",
                    Tipo = DbType.String,
                    Valor = producto.RefCliente,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "@CodEAN",
                    Tipo = DbType.String,
                    Valor = producto.CodEan,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "@GrupoId",
                    Tipo = DbType.String,
                    Valor = producto.GrupoID,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "@Cantidad",
                    Tipo = DbType.Int32,
                    Valor = producto.CantidadSTD,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "@Peso",
                    Tipo = DbType.Int32,
                    Valor = producto.Peso,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "@Operativa",
                    Tipo = DbType.Boolean,
                    Valor = producto.Operativa,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "@LongNumSerie",
                    Tipo = DbType.Int32,
                    Valor = producto.LongNUmSerie,
                    Direccion = TipoDireccion.Entrada
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "@RETCODE",
                    Tipo = DbType.Int32,
                    Direccion = TipoDireccion.EntradaSalida
                };

                parametros.Add(parametro);

                parametro = new ParametroBBDD
                {
                    Nombre = "@Mensaje",
                    Tipo = DbType.String,
                    Direccion = TipoDireccion.EntradaSalida,
                    

                };
                
                parametros.Add(parametro);

                iResultado =_conexion.Ejecutar(SQL,parametros);

                if (iResultado > 0)
                {
                    SQL = "select @@identity";
                    DataTable tabla = _conexion.LeerDatos(SQL);
                    if(tabla!= null)
                    {
                        producto.Id = Convert.ToInt32(tabla.Rows[0][0]);
                    }
                }
            }
            bResultado = _conexion.Cerrar();

            return iResultado;
            

        }

    }
}