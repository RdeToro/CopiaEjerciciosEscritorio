using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LIBCoches
{
    public class Coches
    {
        public List<Coche> ListaCoches { get; set; }

        public Coches()
        {
            ListaCoches = new List<Coche>();

            ListaCoches.Add(new Coche
            {
                Id = 1,
                Marca = "Mercedes",
                Modelo = "Clase C"
            });

            ListaCoches.Add(new Coche
            {
                Id = 2,
                Marca = "Peugeot",
                Modelo = "5008"
            });

            ListaCoches.Add(new Coche
            {
                Id = 3,
                Marca = "Audi",
                Modelo = "A6"
            });

            ListaCoches.Add(new Coche
            {
                Id = 4,
                Marca = "Toyota",
                Modelo = "Yaris"
            });

            ListaCoches.Add(new Coche
            {
                Id = 5,
                Marca = "Citroen",
                Modelo = "C4"
            });
        }
    }
}
