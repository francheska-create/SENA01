using BLL.Contracts;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BLL.TestProject
{
    public class TaxCalculatorWithMockTest
    {
        private readonly TaxCalculator _taxCalculator;
        public TaxCalculatorWithMockTest()
        {
            var mock = new Mock<IDataBase>(MockBehavior.Default);
            mock.Setup(db => db.GetTaxPercentagetByPersonId(It.IsAny<int>())).Returns((0.18));
            mock.Setup(db => db.GetTaxPercentagetByPersonId(0)).Returns((0.12));
            mock.Setup(db => db.GetTaxPercentagetByPersonId(1)).Returns((0.27));
            mock.Setup(db => db.GetTaxPercentagetByPersonId(2)).Returns((0.04));

            _taxCalculator = new TaxCalculator(mock.Object);

        }
        [Theory]
        [InlineData(112, 100, 0)]
        [InlineData(127, 100, 1)]
        [InlineData(104, 100, 2)]
        [InlineData(118, 100, 6)]
        public void CalculateValueForPersonTest(double expected, double amount, int personId)
        {


            //Arrange

            //Act
            var result = _taxCalculator.CalculateTotalValueForPerson(amount, personId);

            //Asert
            Assert.Equal(expected, result);
        }
    }
}
