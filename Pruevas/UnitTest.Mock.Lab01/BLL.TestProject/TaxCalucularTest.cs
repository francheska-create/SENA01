using System;
using BLL;
using BLL.TestProject.ManualMock;
using Xunit;

namespace BLL.TestProject
{
    public class TaxCalucularTest
    {
        private readonly TaxCalculator _taxCalucular;
        public TaxCalucularTest()
        {
            _taxCalucular = new TaxCalculator(new MockDataBase());
        }

        [Theory]
        [InlineData(112,100,0)]
        [InlineData(127, 100, 1)]
        [InlineData(104, 100, 2)]
        [InlineData(118, 100, 6)]
        public void CalculateValueForPersonTest(double expected, double amount, int personId)
        {


            //Arrange

            //Act
            var result = _taxCalucular.CalculateTotalValueForPerson(amount, personId);

            //Asert
            Assert.Equal(expected, result);
        }
    }
}
