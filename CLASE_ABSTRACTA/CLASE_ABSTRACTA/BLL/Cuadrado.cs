using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class Cuadrado : Figura
    {
       
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
           
            return lado* lado;
        }

        public override string ColsultarDatos()
        {
            return  CalcularArea().ToString();
        }

    }
}
