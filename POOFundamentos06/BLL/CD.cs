using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class CD :Publicacion
    { 
        private int intTiempoReproduccion;

        public int TiempoReproduccion
        {
            get { return intTiempoReproduccion; }
            set { intTiempoReproduccion = value; }
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
