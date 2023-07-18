using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.NEGOCIO
{
    public class AvisoRecepcion
    {
        public static bool InsertarAvisoRecepcion()
        { 
            try
            {
                using(var ctx = BD.CURSO_LOGISTICAEntities1())
                {
                    
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
             
            return false; 
        }

    }
}
