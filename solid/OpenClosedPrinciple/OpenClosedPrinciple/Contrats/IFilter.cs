using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Contrats
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}
