using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     public  class UtilidadFecha
    { 
        public  int CalcularEdad(DateTime fechaNacimiento)
        {
            
            if (fechaNacimiento<=DateTime.MinValue||fechaNacimiento>=DateTime.MaxValue)
            {
                throw new ArgumentOutOfRangeException ("Reaised when the  value of  an argument is  outside the range of  valid  values. ");
            
            }     
            else if(fechaNacimiento>=DateTime.Now)
            {
                throw new ArgumentException(" Raised when a non-null argument that  is passed to  a method is invalid ");
            }

            else
            {

                var edad = DateTime.Today.Year-fechaNacimiento.Year;
                var temp = new DateTime(DateTime.Today.Year,
                fechaNacimiento.Month, fechaNacimiento.Day);
                if(temp>DateTime.Today)
                {

                    edad--;
                }

                return edad;

            }
           
        }

     }
}

