using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POOFundamento04WebApplication.Models.entidad
{
    public class Circunferencia
    {
        private double radio;
        [Required(ErrorMessage ="Valor de Radio requerido. Solo Numeros")]
        [Display(Name = "Radio de la circunderencia")]
        [Range(0,double.MaxValue,ErrorMessage ="value for{0}must be between{1} and{2}.")]
        public double Radio
        {
            get { return radio; }


            set
            {
                if (value  < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }


                radio = value;


            }
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
