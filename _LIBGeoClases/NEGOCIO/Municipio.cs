using _LIBGeoClases.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LIBGeoClases.NEGOCIO
{
    public class Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ProvinciaId { get; set; }

        public List<Municipio> GetMunicipiosPorProvinciaId_Negocio(int ProvinciaID)
        {
            List<Municipio> resultado = null;

            AccesoDatos accesoDatos = new AccesoDatos();
            resultado = accesoDatos.GetMunicipiosPorProvinciaId(ProvinciaID);

            return resultado;
        }
    }
}
