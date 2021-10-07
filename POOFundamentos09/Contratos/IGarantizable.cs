using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos
{
    public interface IGarantizable
    { ///defono los miembros pero no los implemento
        public string  Garantia { get; set; }
        public bool ObtenerGarantia();
    }
}
