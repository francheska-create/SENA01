using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Television : AparatoElectrodomestico
    {
        private int botonDeCanales;

        public int BotonDeCanales
        {
            get { return botonDeCanales; }
            set { botonDeCanales = value; }
        }

        private int botonDeVolumen;

        public int BotonDeVolumen
        {
            get { return botonDeVolumen; }
            set { botonDeVolumen = value; }
        }

        public static void CambiarVolumen()
        {
            Console.WriteLine("CambiarVolumen");
        }


        public static void CambiarCanal()
        {
            Console.WriteLine("CambiarCanal");
        }
    }
}