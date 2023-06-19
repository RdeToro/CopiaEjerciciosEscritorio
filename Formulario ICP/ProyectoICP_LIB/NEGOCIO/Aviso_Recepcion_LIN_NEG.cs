using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoICP_LIB.NEGOCIO
{
    public class Aviso_Recepcion_LIN_NEG
    {
        public int ID_AVISO_RECEPCION { get; set; }
        public int LINEA { get; set; }
        public int ID_REFERENCIA { get; set; }
        public int CANTIDAD { get; set; }
        public string LOTE { get; set; }
    }
}
