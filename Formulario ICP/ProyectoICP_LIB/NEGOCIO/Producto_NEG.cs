using ProyectoICP_LIB.BBDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoICP_LIB.NEGOCIO
{
    public class Producto_NEG
    {
        #region PROPIEDADES
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string CodReferencia { get; set; }
        public string Descripcion { get; set; }
        public string RefCliente { get; set; }
        public string CodEan { get; set; }
        public string GrupoID { get; set; }
        public int CantidadSTD { get; set; }
        public int Peso { get; set; }
        public bool Operativa { get; set; }
        public int LongNUmSerie { get; set; }
        #endregion

        public List<Producto_NEG> GetProductos()
        {
            List<Producto_NEG> resultado = null;

            Producto_BBDD productoBBDD = new Producto_BBDD(Utilidades.CadenaConexion);
            resultado = productoBBDD.LeerProductos();

            return resultado;
        }

        public Producto_NEG GetProducto(int ProductoId)
        {
            List<Producto_NEG> resultado = null;

            Producto_BBDD productoBBDD = new Producto_BBDD(Utilidades.CadenaConexion);
            resultado = productoBBDD.LeerProductos(ProductoId);

            return resultado.FirstOrDefault();
        }

        public int Rellenar(Producto_NEG Producto)
        {
            Producto_BBDD PBBDD = new Producto_BBDD(Utilidades.CadenaConexion);

            int id = PBBDD.Insertar(Producto);

            return id;
            
        }
    }
}
