using _LIBGeoClases.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LIBGeoClases.NEGOCIO
{
    public class Provincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ComunidadId { get; set; }

        public List<Provincia> GetProvinciasPorComunidadId_Negocio(int ComunidadID)
        {
            List<Provincia> resultado = null;

            AccesoDatos accesoDatos = new AccesoDatos();
            resultado = accesoDatos.GetProvinciasPorComunidadId(ComunidadID);

            return resultado;
        }
    }
}
