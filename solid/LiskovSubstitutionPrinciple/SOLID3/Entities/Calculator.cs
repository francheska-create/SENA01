using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Entities
{
   public abstract class Calculator
    {
        // ReSharper disable once InconsistentNoming
        protected readonly int[] _numbers;

        protected Calculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public abstract int Calculate();
    }
}
