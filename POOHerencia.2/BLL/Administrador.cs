using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Administrador : Empleado
    {
        private int puesto;
        public int Puesto
        {
            get { return puesto; }
            set { puesto = value; }

        }


        public static void Administrar()
        {
            Console.WriteLine("administrar");
        }
    }
}