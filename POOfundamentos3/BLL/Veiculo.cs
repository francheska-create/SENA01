using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BLL
{
    public class Veiculo
    {

        private int caballosFuerza;

        public int Caballosfuerza

        {
            get { return caballosFuerza; }
            set { caballosFuerza =value; }


        }


        public void Arrancar()
        {
            Console.WriteLine("arancando el  vehiculo");

        }

        public void Detener()
        {
            Console.WriteLine("detener el  vehiculo");

        }
    }
}















    

