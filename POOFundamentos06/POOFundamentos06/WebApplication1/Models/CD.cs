using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
   public class CD :Publicacion
    { 
        private int tiempoReproduccion;

        public int TiempoReproduccion
        {
            get { return tiempoReproduccion; }
            set { tiempoReproduccion = value; }
        }

        public CD()
        {

        }

        public CD(string titulo,double Precio,int tiempoReproduccion)
            :base(titulo,Precio)
        {
            this.TiempoReproduccion = tiempoReproduccion;
        }
    }
}
