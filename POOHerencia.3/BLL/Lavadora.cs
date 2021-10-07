using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Lavadora : AparatoElectrodomestico
    {
        private int perillaDeCiclosDeLavado;

        public int PerillaDeCiclosDeLavado
        {
            get { return perillaDeCiclosDeLavado; }
            set { perillaDeCiclosDeLavado = value; }
        }

        private int capacidadDeCarga;

        public int CapacidadDeCarga
        {
            get { return capacidadDeCarga; }
            set { capacidadDeCarga = value; }
        }

        public static void LlenarConAgua()
        {
            Console.WriteLine("LlenarConAgua");
        }
        public static void TirarAgua()
        {
            Console.WriteLine("TirarAgua");
        }
    }
}