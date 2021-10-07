using InterfaceSegregationPrinciple.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Entities
{
    class Airplane : IAirplane
    {
           public void Fly()
           {
            Console.WriteLine("Flying a plane");
           }
    }
}
