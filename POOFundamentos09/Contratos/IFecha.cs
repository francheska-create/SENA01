using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos
{
    public interface IFecha
    {
        public int Dia();

        public int mes();

        public string mesconLetra();

        public int anio();
    }
}
