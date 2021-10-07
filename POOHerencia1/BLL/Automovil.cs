using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Automovil : VehiculoTerrestre
    {
        private int cantidadPuertas;

        public int CantidadPuertas
        {
            get { return cantidadPuertas; }
            set { cantidadPuertas = value; }
        }

        public new void Acelerar(int cuanto)
        {
            Console.WriteLine("El automovil acelera {0} Km/h", cuanto);

        }

    }
}
