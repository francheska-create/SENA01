using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Automovil : Veiculo
    {

        private int Cantidadpuertas;

        public int cantidadpuertas
        {
            get { return Cantidadpuertas; }
            set { Cantidadpuertas = value; }
        }

             public void Acelerar(int cuanto)
        {
            Console.WriteLine("El auntomovil acelera{0}km/h.", cuanto);
        }
    }
    }
          

        
    









