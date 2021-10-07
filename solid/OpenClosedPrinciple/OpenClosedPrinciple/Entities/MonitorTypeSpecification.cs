using OpenClosedPrinciple.Contrats;
using OpenClosedPrinciple.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Entities
{
    class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly MonitorType _tipe;
        public MonitorTypeSpecification(MonitorType  type)
        {
            _tipe = type;
        }
        public bool ISastiFiel(ComputerMonitor iten) => iten.Type == _tipe;
       
    }

   
}