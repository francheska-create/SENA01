using OpenClosedPriciple.CalculadoraSalario;
using OpenClosedPriciple.Entities;
using System;
using System.Collections.Generic;

namespace OpenClosedPriciple
{
    class Program
    {
        private static IEnumerable<BaseSalaryCalculator> developerCalculation;

        static void Main(string[] args)
        {
            var devReports = new List<DeveloperReport>
            {
             new DeveloperReport{Id=1,name="Deve1", Level="senior Developer", HourlyRate=30.5, WorkingHours=160},
             new DeveloperReport{Id=1,name="Deve2", Level="senior Developer", HourlyRate=30.5, WorkingHours=160},
             new DeveloperReport{Id=1,name="Deve3", Level="senior Developer", HourlyRate=30.5, WorkingHours=160},


            };
            var calculator = new SalaryCalculator(developerCalculation);
            Console.WriteLine($"sun of all the developer salaries is{calculator.CalculateTotalSalaries()}dollart");
        }
    }
}
