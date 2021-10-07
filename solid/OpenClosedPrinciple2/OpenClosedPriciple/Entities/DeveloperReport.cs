using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPriciple.Entities
{
    class DeveloperReport
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }
}
