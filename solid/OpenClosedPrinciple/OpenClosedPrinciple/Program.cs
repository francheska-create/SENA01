using OpenClosedPrinciple.Entities;
using OpenClosedPrinciple.Enumeraciones;
using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var monitors = new List<ComputerMonitor>
            {
             new ComputerMonitor{name="SAMSUM S345",Screen=Screen.CurvedScree,Type=MonitorType.OLED},
             new ComputerMonitor{name="Philips P532",Screen=Screen.CurvedScree,Type=MonitorType.LCD},
             new ComputerMonitor{name="SAMSUM S9999",Screen=Screen.CurvedScree,Type=MonitorType.LED},
             new ComputerMonitor{name="DELL D02J41",Screen=Screen.CurvedScree,Type=MonitorType.LCD},
            };

            var filter = new MonitorFilter();
            var lcmdMonitors = filter.FiterByType(monitors,MonitorType.LCD);

            Console.WriteLine("All LCD MONITORS");
            foreach (var Monitor in lcmdMonitors) 
            {

                Console.WriteLine($"name{Monitor.name },Type{Monitor.Type},Screen{Monitor.Screen}");
            }
        }
    }
}
