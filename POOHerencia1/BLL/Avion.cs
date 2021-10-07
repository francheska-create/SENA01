using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Avion :VehiculoAereo
    {
        private int numeroTurbinas;

        public int NumeroTurbinas
        {
            get { return numeroTurbinas; }
            set { numeroTurbinas = value; }
        }


        public new void Elevacion(int altura)
        {
            Console.WriteLine("El avion se eleva {0} msnm", altura);

        }

    }
}
