using DependencyInversionPrinciple.Entities;
using DependencyInversionPrinciple.Enums;
using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeManager= new EnployeeManager();
            employeeManager.AddEnployee(new Employee {name="fran",Gender=Gender.Fenale, position= Position.Manager });
            employeeManager.AddEnployee(new Employee { name = "Mike", Gender = Gender.Male, position = Position.Administractor });
            var stats =new EnployeeStatics(employeeManager);
            Console.WriteLine(value: $"Number of fenale managers in our company is{stats.countFenalManager()}");
        }
    }
}
