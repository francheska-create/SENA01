using System;

namespace BLL
{
    public class Vehiculo
    {
        private int caballosFuerza;

        public int CaballosFuerza
        {
            get { return caballosFuerza; }
            set { caballosFuerza = value; }
        }


        public void Arrancar()
        {
            Console.WriteLine("Arrancando el vehiculo");
        }

        public void Detener()
        {
            Console.WriteLine("Deteniendo el vehiculo");
        }

    }
}
