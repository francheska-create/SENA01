using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Entities
{
  public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) 
            : base(numbers)
        {

        }

        // public readonly int[] _numbers;

        // public SumCalculator(int[] numbers)
        //{
        //  _numbers = numbers;
        // }

        // public int Calculate() => _numbers.Sum();

        public override int Calculate() => _numbers.Sum();
        
    }
}
