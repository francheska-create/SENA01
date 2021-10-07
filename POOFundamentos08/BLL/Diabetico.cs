using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     public class Diabetico : Persona
    {

        public override void comer()
        {
            Console.WriteLine("dieta baja en azucar y carnes rojas");
        }


    }
}
