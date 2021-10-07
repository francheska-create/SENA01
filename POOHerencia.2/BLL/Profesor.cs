using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Profesor : Empleado
    {
        private int carrera;

        public int Carrera
        {
            get { return carrera; }
            set { carrera = value; }

        }


        public static void Enseñar()
        {
            Console.WriteLine("enseñar");
        }
    }
}