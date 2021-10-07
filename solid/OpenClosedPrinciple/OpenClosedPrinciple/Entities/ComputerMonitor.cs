using OpenClosedPrinciple.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Entities
{
  public  class ComputerMonitor
    {
        public string name{ get; set; }
        public MonitorType Type{ get; set; }
        public Screen Screen { get; set; }
    }
}