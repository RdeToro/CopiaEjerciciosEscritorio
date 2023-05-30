using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCEDIMIENTOS_LIB.Negocio
{
    public class AvisoRecepcionesLIN
    {
        
        public AvisoRecepcionesLIN NuevoLIN { get; set; }

        public List<AvisoRecepcionesLIN> lista;
        public int ID_REFERENCIA { get; set; }
        public int CANTIDAD { get; set; }
        public string LOTE { get; set; }

        public ConexionConDatos miConexion { get; set; }

        public AvisoRecepcionesLIN()
        {
            miConexion = new ConexionConDatos(lista);            
        }



        public List<AvisoRecepcionesLIN> Rellenar (AvisoRecepcionesLIN lIN)
        {
            NuevoLIN = new AvisoRecepcionesLIN
            {
                CANTIDAD = lIN.CANTIDAD,
                LOTE = lIN.LOTE,
                ID_REFERENCIA = lIN.ID_REFERENCIA
            };

            lista.Add(NuevoLIN);

            return lista;

        }
    }
}
    
