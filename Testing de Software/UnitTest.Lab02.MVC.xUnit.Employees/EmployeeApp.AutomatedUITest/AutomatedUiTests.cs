using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using Xunit;

namespace EmployeeApp.AutomatedUITest
{
    public class AutomatedUiTests : IDisposable
    {
        private readonly IWebDriver _driver;
        public AutomatedUiTests()
        {
            _driver = new ChromeDriver();
        }

        [Fact]
        public void Create_WhenExecuted_ReturnsCreateView()
        {
            _driver.Navigate()
            .GoToUrl("https://localhost:5001/Employees/Create");
            Assert.Equal("Create - EmployeesApp", _driver.Title);
            Assert.Contains("Please provide a new employee data", _driver.PageSource);
        }

        [Fact]
        public void Create_WrongModelData_ReturnsErrorMessage()
        {
            _driver.Navigate()
            .GoToUrl("https://localhost:5001/Employees/Create");
            _driver.FindElement(By.Id("Name"))
            .SendKeys("Test Employee");
            _driver.FindElement(By.Id("Age"))
            .SendKeys("34");
            _driver.FindElement(By.Id("Create"))
            .Click();
            var errorMessage = _driver.FindElement(By.Id("AccountNumber-error")).Text;
            Assert.Equal("Account number is required", errorMessage);
            Thread.Sleep(15000);
        }

        [Fact]
        public void Create_WhenSuccessfullyExecuted_ReturnsIndexViewWithNewEmployee()
        {
            _driver.Navigate()
            .GoToUrl("https://localhost:5001/Employees/Create");
            _driver.FindElement(By.Id("Name"))
            .SendKeys("Casi Miro");
            _driver.FindElement(By.Id("Age"))
            .SendKeys("35");
            _driver.FindElement(By.Id("AccountNumber"))
            .SendKeys("123-9384613085-58");
            _driver.FindElement(By.Id("Create"))
            .Click();
            Thread.Sleep(10000);
            _driver.Navigate()
            .GoToUrl("https://localhost:5001/");
            Thread.Sleep(10000);
            Assert.Equal("Index - EmployeesApp", _driver.Title);
            Assert.Contains("Casi Miro", _driver.PageSource);
            Assert.Contains("35", _driver.PageSource);
            Assert.Contains("123-9384613085-58", _driver.PageSource);
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
            Thread.Sleep(15000);
        }
    }
}
