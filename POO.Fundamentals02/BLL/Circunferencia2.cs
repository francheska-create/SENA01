using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{   //programacion clasica Funcional orientada a objetos//
    public class Circunferencia2
    {
        private double radio;

        public double ModificarRadio
        {
            get { return radio; }
            set { radio = value; }
        
        }
        public double CalcularArea() => Math.PI * Math.Pow(radio, 2);
        public double CalcularPerimetro() => Math.PI * radio;
    }



}       
    

