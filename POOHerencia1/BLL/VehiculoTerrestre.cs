using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VehiculoTerrestre : Vehiculo
    {
        private int numeroRin;

        public int NumeroRin 
        {
            get { return numeroRin; }
            set { numeroRin = value; }
        }

        public void Acelerar(int cuanto)
        {
            Console.WriteLine("El vehiculo terrestre acelera {0} km/h.", cuanto);
        }

    }
}
