using EmployeesApp.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmployyeesAppTest.Validation
{
    public class AccountNumberValidationTest
    {
        private readonly AccountNumberValidation _accountNumberValidation;

        public AccountNumberValidationTest()
        {
            _accountNumberValidation = new AccountNumberValidation();
        }

        /*Numero de cuenta correcto*/
        [Fact]
        public void IsValid_validAccountNumber_ReturnsTrue()
        {
            Assert.True(_accountNumberValidation.IsValid("123-4543234576-23"));

        }

        /*Numero de cuenta incorrecto*/
        //[Fact]
        //public void IsValid_AccountNumberFirstPartWrong_ReturnFlse()
        //{
        //    Assert.False(_accountNumberValidation.IsValid("1234-3454565676-23"));
        //}

        [Theory]
        [InlineData("1234-3454565676-23")]
        [InlineData("12-3454565676-23")]
        public void IsValid_AccountNumberFirstPartWrong_WithTheory_ReturnFalse(string accountNumber)
        {
            Assert.False(_accountNumberValidation.IsValid(accountNumber));
        }

        [Theory]
        [InlineData("123-3454565676-2")]
        [InlineData("123-3454565676-233")]
        public void IsValid_AccountNumberLastPartWrong_WithTheory_ReturnFalse(string accountNumber)
        {
            Assert.False(_accountNumberValidation.IsValid(accountNumber));
        }

        [Theory]
        [InlineData("123-345455676-23")]
        [InlineData("123-34545465676-23")]
        public void IsValid_AccountNumberMiddlePartWrong_WithTheory_ReturnFalse(string accountNumber)
        {
            Assert.False(_accountNumberValidation.IsValid(accountNumber));
        }
        [Theory]
        [InlineData("123-3454556764=23")]
        [InlineData("123+3454546567-23")]
        [InlineData("123+3454546567=23")]
        public void IsValid_InvalidDelimiters_ThrowsArgumentException_WithTheory_ReturnFalse(string accountNumber)
        {
            Assert.Throws<ArgumentException>(()=>_accountNumberValidation.IsValid(accountNumber));
        }
    }
}
