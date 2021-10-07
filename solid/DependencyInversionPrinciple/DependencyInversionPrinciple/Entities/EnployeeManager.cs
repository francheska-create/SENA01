using DependencyInversionPrinciple.Contracts;
using DependencyInversionPrinciple.Enums;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple.Entities
{
   public class EnployeeManager:IEmployeeShearchable
    {
        private readonly List<Employee> _Employees;



        public EnployeeManager()
        {
            _Employees= new List<Employee>();
        }
        public void AddEnployee(Employee employee)
        {
            _Employees.Add(employee);
        
        }

        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
        
            =>_Employees.Where(emp => emp.Gender == Gender.Fenale && emp.position == Position.Manager);
        

        
    }
}
