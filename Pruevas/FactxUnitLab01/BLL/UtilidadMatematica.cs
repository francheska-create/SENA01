using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class UtilidadMatematica
    {

        public static double Sumar(double a, double b) => a + b;
        public static double Restar(double a, double b) => a - b;
        public static double Multiplicar(double a, double b) => a * b;

        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            
            
            }
            return a / b;
        }
    }
}
