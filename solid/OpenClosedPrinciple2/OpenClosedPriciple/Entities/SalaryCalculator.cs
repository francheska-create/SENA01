using OpenClosedPriciple.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPriciple.CalculadoraSalario
{
    class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation;
        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerCalculation)
        {
            _developerCalculation = developerCalculation;
        }

        public double CalculateTotalSalaries()
        {
            return _developerCalculation.Sum(devCal => devCal.CalculateSalary());
        }

            
    }
}