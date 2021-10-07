using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Contrats
{
     public interface ISpecification<T>
    {
        bool ISastiFiel(T iten);
    }
}