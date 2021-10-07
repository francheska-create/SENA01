using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Helicoptero : VehiculoAereo
    {
        private int eleva;

        public int Eleva
        {
            get { return eleva; }
            set { eleva = value; }
        }

        public new void Elevacion(int altura)
        {
            Console.WriteLine("El Helicoptero se eleva {0} Km/h", altura);

        }
    }
}