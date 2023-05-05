using _LIBGeoClases.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LIBGeoClases.NEGOCIO
{
    public class Poblacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int MunicipioId { get; set; }

        public List<Poblacion> GetPoblacionesPorMunicipioId_Negocio(int MunicipioID)
        {
            List<Poblacion> resultado = null;

            AccesoDatos accesoDatos = new AccesoDatos();
            resultado = accesoDatos.GetPoblacionesPorMunicipioId(MunicipioID);

            return resultado;
        }
    }
}
