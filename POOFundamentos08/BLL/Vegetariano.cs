using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Vegetariano:Persona
    {
        public override void comer()
        {
            Console.WriteLine("Dieta sin carne.solo vegetales");
        }

    }
}
