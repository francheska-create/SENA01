using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Publicacion
    {
     
 
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
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
