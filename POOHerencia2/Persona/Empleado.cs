using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Empleado : Persona
    {
        private String jefe;

        public String Jefe
        {
            get { return jefe; }
            set { jefe = value; }
        }

        public static void Cobrar()
        {
            Console.WriteLine("cobrar");
        }

    }
}
