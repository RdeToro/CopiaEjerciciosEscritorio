using Microsoft.Identity.Client;
using PROCEDIMIENTOS_LIB.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROCEDIMIENTOS_LIB.Negocio
{
    public class ConexionConDatos
    {
        private string _CadenaConexion { get; set; } = @"Server = Ayla\tsql7; Database=CURSO_LOGISTICA;User Id = sa; Password=Aa123456;";
        public AvisoRecepcionesCab_Lin_Datos CapaDatos { get; set; }
        public AvisoRecepcionesCAB MiCab { get; set; }
        public List<AvisoRecepcionesCAB> misCabeceras { get; set; }
        public List<AvisoRecepcionesLIN> misLineas { get; set; }

        public ConexionConDatos(AvisoRecepcionesCAB miCab)
        {
            MiCab = miCab;              
            
        }

        public ConexionConDatos(List<AvisoRecepcionesLIN> miLIN)
        {
            misLineas = miLIN;         
        }

        public ConexionConDatos(AvisoRecepcionesCab_Lin_Datos capa)
        {
            CapaDatos = new AvisoRecepcionesCab_Lin_Datos(_CadenaConexion, MiCab, misLineas);

            
            misCabeceras = capa.LeerCABBBDD();

            
            
            
        }




    }
}
