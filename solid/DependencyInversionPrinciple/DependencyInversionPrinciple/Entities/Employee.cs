using DependencyInversionPrinciple.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Entities
{
   public  class Employee
    {
        public string name { get; set; }
        public Gender  Gender{ get; set; }
        public Position position { get; set; }
    }
}
