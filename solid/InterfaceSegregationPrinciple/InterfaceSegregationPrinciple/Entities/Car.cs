using InterfaceSegregationPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Entities
{
    class Car : ICar
    {
       public void Drive()
        {
            Console.WriteLine("Driving a car");
        }

       
    }
}
