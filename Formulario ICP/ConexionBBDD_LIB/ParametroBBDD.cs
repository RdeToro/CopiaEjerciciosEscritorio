using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBBDD_LIB
{
    public class ParametroBBDD
    {
        public enum TipoDireccion
        {
            Entrada, Salida, EntradaSalida
        }
        public string Nombre { get; set; }
        public DbType  Tipo { get; set; }
        public object Valor { get; set; }
        public TipoDireccion Direccion { get; set; }
        public int Tamanho { get; set; }

        public SqlDbType TipoSQL { get; set; }




    }
}
