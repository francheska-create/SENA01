using OpenClosedPrinciple.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Entities
{
  public  class MonitorFilter
    {
        public List<ComputerMonitor>FiterByType(IEnumerable<ComputerMonitor>monitors, MonitorType type) =>
           monitors.Where(m=>m.Type==type).ToList();
        public List<ComputerMonitor> FiterScreen(IEnumerable<ComputerMonitor> monitors, Screen Screen) =>
           monitors.Where(m =>m.Screen == Screen).ToList();

    }
}
