using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Libro : Publicacion
    {
        private int numeroPaginas;

        public int NumeroPaginas
        {
            get { return numeroPaginas; } //obtener
            set { numeroPaginas = value; } //otorgar valor
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

