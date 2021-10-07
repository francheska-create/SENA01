using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class AparatoElectrodomestico
    {
        private int interruptor;

        public int Interruptor
        {
            get { return interruptor; }
            set { interruptor = value; }
        }

        private int cableElectrico;

        public int CableElectrico
        {
            get { return cableElectrico; }
            set { cableElectrico = value; }
        }





        public static void Encender()
        {
            Console.WriteLine("Encender");
        }

        public static void Apagar()
        {
            Console.WriteLine("Apagar");
        }

    }
}