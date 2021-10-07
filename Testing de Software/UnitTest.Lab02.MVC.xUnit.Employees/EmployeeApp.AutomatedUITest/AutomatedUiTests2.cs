using EmployeeApp.AutomatedUITest.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace EmployeeApp.AutomatedUITest
{
        public class AutomatedUITests2 : IDisposable
        {
            private readonly IWebDriver _driver;
            private readonly EmployeePage _page;
            public AutomatedUITests2()
            {
                _driver = new ChromeDriver();
                _page = new EmployeePage(_driver);
                _page.Navigate();
            }
            [Fact]
            public void Create_WhenExecuted_ReturnsCreateView()
            {
                Assert.Equal("Create - EmployeesApp", _page.Title);
                Assert.Contains("Please provide a new employee data", _page.Source);
                Thread.Sleep(5000);
            }
            [Fact]
            public void Create_WrongModelData_ReturnsErrorMessage()
            {
                _page.PopulateName("New Name");
                _page.PopulateAge("34");
                _page.ClickCreate();
                Assert.Equal("Account number is required", _page.AccountNumberErrorMessage);
                Thread.Sleep(5000);
            }
            [Fact]
            public void Create_WhenSuccessfullyExecuted_ReturnsIndexViewWithNewEmployee()
            {
                _page.PopulateName("New Name");
                _page.PopulateAge("34");
                _page.PopulateAccountNumber("123-9384613085-58");

                _page.ClickCreate();
                Assert.Equal("Index - EmployeesApp", _page.Title);
                Assert.Contains("New Name", _page.Source);
                Assert.Contains("34", _page.Source);
                Assert.Contains("123-9384613085-58", _page.Source);
                Thread.Sleep(5000);
            }
            public void Dispose()
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }
    
}
