using DependencyInversionPrinciple.Contracts;
using DependencyInversionPrinciple.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DependencyInversionPrinciple.Entities
{
    public class EnployeeStatics
    {
        private readonly IEmployeeShearchable _emp;
        public EnployeeStatics(IEmployeeShearchable emp)
        {
            _emp = emp;
        }
        public int countFenalManager() =>
            _emp.GetEmployeesByGenderAndPosition(Gender.Fenale, Position.Manager).Count();




    }
}
   

