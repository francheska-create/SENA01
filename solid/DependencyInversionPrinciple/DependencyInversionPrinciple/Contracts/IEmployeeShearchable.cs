using DependencyInversionPrinciple.Entities;
using DependencyInversionPrinciple.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Contracts
{
    public interface IEmployeeShearchable
    {
        IEnumerable<Employee>GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}
