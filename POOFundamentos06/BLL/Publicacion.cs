using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Publicacion
    {
     
 
        private double dblPrecio;

        public double Precio
        {
            get { return dblPrecio; }
            set { dblPrecio = value; }
        }

        private string strTitulo;

        public string Titulo
        {
            get { return strTitulo; }
            set { strTitulo = value; }
        }
        public Publicacion()
        {

        }
        public Publicacion(string titulo,double precio)

        {
            this.Titulo = titulo;
            this.Precio = precio;
        }
    }
}
