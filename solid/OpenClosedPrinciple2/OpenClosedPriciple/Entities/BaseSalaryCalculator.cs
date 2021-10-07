using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPriciple.Entities
{
    abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport{get;}

        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }
        public abstract double CalculateSalary();
    }
}
