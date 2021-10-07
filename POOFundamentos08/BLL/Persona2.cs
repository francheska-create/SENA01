using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   abstract class Persona2
    {
        public string Nombres { get; set; }
        public string Apellidos{ get; set; }
        ////propiedad abstracta
        public abstract int Identificacion { get; set; }
        ///metodo Astracto
        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return this.Apellidos+ $""+this.Nombres;
        }
    }
}
