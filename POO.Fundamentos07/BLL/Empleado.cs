
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public sealed class Empleado :Persona
    {
        public string Departamento { get; set; }


        public Empleado()
        {
            Departamento = "finanzas";
        }

        public Empleado(string departamento)
        {
            this.Departamento = departamento;
        }

    }
}
