using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Profesor : Empleado
    {
        private String carrera;

        public String Carrera
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
