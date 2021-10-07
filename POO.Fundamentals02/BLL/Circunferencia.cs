using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{ //programacion clasica orientada a objetos//
    public class Circunferencia
    {
       
        private double radio;
        public void ModificarRadio(double radio) 
        {
          this.radio=radio;
        }
        public double ConsultarRadio() 
        {
            return Math.PI * Math.Pow(radio, 1);
        }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

         public double CalcularPerimetro() 
        {
            return 2 * Math.PI * radio;
        }

        
    }
}
