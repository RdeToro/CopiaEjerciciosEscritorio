using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCEDIMIENTOS_LIB.Datos
{
    public class PARAMETRO
    {
        public string Nombre { get; set; }
        public DataType Tipo { get; set; }
        public string Valor { get;}
        public string Direccion { get; set; }
    }
}
