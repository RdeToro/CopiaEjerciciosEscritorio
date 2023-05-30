using PROCEDIMIENTOS_LIB.Datos;

namespace PROCEDIMIENTOS_LIB.Negocio
{
    public class AvisoRecepcionesCAB
    {
        
        public AvisoRecepcionesCAB MiRecepcion { get; set; }

        public ConexionConDatos miConexion { get; set; }
        public int Id_Aviso_Recepciones { get; set; }
        public DateTime Fecha { get; set; }
        public int ESTADO_AVISO { get; set; }
        public string COD_PEDIDO { get; set; }
        public int ID_PROVEEDOR { get; set; }
        public int TIPO_AVISO { get; set; }

        public AvisoRecepcionesCAB()
        {            
            miConexion = new ConexionConDatos(MiRecepcion);         
        }

        public AvisoRecepcionesCAB Rellenar(AvisoRecepcionesCAB cab)
        {
            
            MiRecepcion = new AvisoRecepcionesCAB
            {
                ESTADO_AVISO = cab.ESTADO_AVISO,
                COD_PEDIDO = cab.COD_PEDIDO,
                ID_PROVEEDOR = cab.ID_PROVEEDOR,
                TIPO_AVISO = cab.TIPO_AVISO
                
            };
            return MiRecepcion;

            
        }





    }
}