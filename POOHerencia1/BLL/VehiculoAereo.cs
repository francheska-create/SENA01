using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VehiculoAereo : Vehiculo
    {
        private int metrosSobreMar;

        public int MetrosSobreMar
        {
            get { return metrosSobreMar; }
            set { metrosSobreMar = value; }
        }

        public void Elevacion (int altura)
        {
            Console.WriteLine("El vehiculo aereo se eleva {0} msnm", altura);

        }

    }
}
