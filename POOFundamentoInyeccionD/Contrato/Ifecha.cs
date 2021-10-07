using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos
{
    public  interface Ifecha
    {
        public DateTime fecha{ get; set; }

        public  string  FechaConLetra();


    }
}
