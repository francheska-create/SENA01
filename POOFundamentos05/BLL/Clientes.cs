using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Clientes:Persona
    {
        public bool MayorEdad()
        {

            var edad = 0;

            Persona persona = new Persona();
               edad = base.CalcularEdad();
            if (edad >= 18) {
                return true;
            }
            else {
                return false;
            }
        }
    }


       
    
}
