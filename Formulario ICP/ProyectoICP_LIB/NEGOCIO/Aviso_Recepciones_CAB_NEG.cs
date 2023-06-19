using ProyectoICP_LIB.BBDD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoICP_LIB.NEGOCIO
{
    public class Aviso_Recepciones_CAB_NEG
    {
        public int ID_AVISO_RECEPCION { get; set; }
        public DateTime FECHA_INSERT { get; set; }
        public byte ESTADO_AVISO { get; set; }
        public string COD_PEDIDO { get; set; }
        public int ID_PROVEEDOR { get; set; }
        public byte TIPO_AVISO { get; set; }

        public List<Aviso_Recepciones_CAB_NEG> GetAvisoRecepcionesCAB ()
        {
            List<Aviso_Recepciones_CAB_NEG> resultado = new List<Aviso_Recepciones_CAB_NEG>();
            Aviso_Recepciones_CAB_NEG recepcion = null;
            Aviso_Recepciones_BBDD aviso = new Aviso_Recepciones_BBDD();

            DataTable datos = null;

            datos = aviso.LeerCAB();

            if (resultado != null && datos.Rows.Count > 0) 
            {
                foreach (DataRow row in datos.Rows)
                {
                    recepcion = new Aviso_Recepciones_CAB_NEG
                    {
                        ID_AVISO_RECEPCION = Convert.ToInt32(row["ID_AVISO_RECEPCION"]),
                        FECHA_INSERT = Convert.ToDateTime(row["FECHA_INSERT"]),
                        ESTADO_AVISO = Convert.ToByte(row["ESTADO_AVISO"]),
                        COD_PEDIDO = row["COD_PEDIDO"].ToString(),
                        ID_PROVEEDOR = Convert.ToInt32(row["ID_PROVEEDOR"]),
                        TIPO_AVISO = Convert.ToByte(row["TIPO_AVISO"])
                    };
                    
                    resultado.Add(recepcion);
                }
            }
            return resultado;

        }

        public List<Aviso_Recepciones_CAB_NEG> GetAvisoRecepcionCAB(int Id_Aviso_recepcion)
        {
            List<Aviso_Recepciones_CAB_NEG> resultado = new List<Aviso_Recepciones_CAB_NEG>();
            Aviso_Recepciones_CAB_NEG recepcion = null;
            Aviso_Recepciones_BBDD aviso = null;

            DataTable datos = null;

            datos = aviso.LeerCAB(Id_Aviso_recepcion);

            if (resultado != null && datos.Rows.Count > 0)
            {
                foreach (DataRow row in datos.Rows)
                {
                    recepcion = new Aviso_Recepciones_CAB_NEG
                    {
                        ID_AVISO_RECEPCION = Convert.ToInt32(row["ID_AVISO_RECPCION"]),
                        FECHA_INSERT = Convert.ToDateTime(row["FECHA_INSERT"]),
                        ESTADO_AVISO = Convert.ToByte(row["ESTADO_AVISO"]),
                        COD_PEDIDO = row["COD_PEDIDO"].ToString(),
                        ID_PROVEEDOR = Convert.ToInt32(row["ID_PROVEEDOR"]),
                        TIPO_AVISO = Convert.ToByte(row["TIPO_AVISO"])
                    };

                    resultado.Add(recepcion);
                }
            }
            return resultado;

        }


        public void Rellenar (Aviso_Recepciones_CAB_NEG CAB,List<Aviso_Recepcion_LIN_NEG> LIN)
        {
            Aviso_Recepciones_BBDD BBDD = new Aviso_Recepciones_BBDD();

            DataTable Tabla = new DataTable();

            Tabla.Columns.Add("LINEA", typeof(int));
            Tabla.Columns.Add("ID_REFERENCIA", typeof(int));
            Tabla.Columns.Add("CANTIDAD", typeof(int));
            Tabla.Columns.Add("LOTE", typeof(string));

            foreach (Aviso_Recepcion_LIN_NEG lin in LIN)
            {
                DataRow row = Tabla.NewRow();

                row["LINEA"] = lin.LINEA;
                row["ID_REFERENCIA"] = lin.ID_REFERENCIA;
                row["CANTIDAD"] = lin.CANTIDAD;
                row["LOTE"] = lin.LOTE;

                Tabla.Rows.Add(row);

            }

            if(Tabla.Rows.Count > 0) 
            {
                BBDD.Insertar(CAB, Tabla);
            }

            
        }



    }
}
