using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Bicicleta : VehiculoTerrestre
    {
        private int cantidadRuedas;

        public int CantidadRuedas
        {
            get { return cantidadRuedas; }
            set { cantidadRuedas = value; }
        }

        public new void Acelerar(int cuanto)
        {
            Console.WriteLine("La bicicleta Acelera {0} Km/h", cuanto);

        }

    }
}
