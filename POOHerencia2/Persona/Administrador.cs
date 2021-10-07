using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Administrador : Empleado
    {
        private String puesto;

        public String Puesto
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
