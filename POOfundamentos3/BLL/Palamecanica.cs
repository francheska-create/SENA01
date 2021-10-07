using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
     public class Palamecanica : Veiculo
    {

        private int Pesomaximolevante;
        public int pesomaximolevante

        {
            get { return Pesomaximolevante; }
            set { Pesomaximolevante = value; }

        }

        public void Moverpala(string direccion)
        {
            Console.WriteLine(" la pala mecanica se mueva a la {0}",direccion);
        }
    }
}



































