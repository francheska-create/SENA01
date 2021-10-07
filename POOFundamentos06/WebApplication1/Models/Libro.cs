using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPublicacion
{
    public class Libro : Publicacion
    {
        private int numeroPaginas;

        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }

        public Libro()
        {

        }

        public Libro(string titulo, double precio, int numeroPaginas)
            : base(titulo, precio)
        {
            this.NumeroPaginas = numeroPaginas;
        }
    }       
}  

