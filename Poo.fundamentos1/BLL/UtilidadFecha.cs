using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     public static class UtilidadFecha
    {
        public static int CalcularEdad(DateTime FechaNacimiento)
        {
            var Edad = DateTime.Today.Year - FechaNacimiento.Year;
            var temp = new DateTime(DateTime.Today.Year,
                FechaNacimiento.Month, FechaNacimiento.Day);
            if (temp > DateTime.Today) 
                    {
                Edad--;
            }
            return Edad;
        }
    }
}
