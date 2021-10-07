using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Empleado : Persona2
    {
        public override int Identificacion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string ConsultarDatos()
        {
            return base.ToString() + $"" + this.Identificacion;
        }
    }
}
