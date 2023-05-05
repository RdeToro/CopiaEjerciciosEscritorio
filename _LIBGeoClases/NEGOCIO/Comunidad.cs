using _LIBGeoClases.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LIBGeoClases.NEGOCIO
{
    public class Comunidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Comunidad> GetComunidades_Negocio()
        {
            List<Comunidad> resultado = null;

            AccesoDatos accesoDatos = new AccesoDatos();
            resultado = accesoDatos.GetComunidades();

            return resultado;
        }
    }
}
