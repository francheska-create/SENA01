using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Empleado : Persona
    {
        private int Jefe;
        public int jefe
        {
            get { return Jefe; }
            set { Jefe = value; }
        }

        public static void Cobrar()
        {
            Console.WriteLine("cobrar");
        }



    }
}