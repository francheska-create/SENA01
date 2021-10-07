using EmployeesApp.Contracts;
using EmployeesApp.Controllers;
using EmployeesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmployyeeAppTest.Controllers
{
    public class EmployeesControllerTest
    {
        private readonly Mock<IEmployeeRepository> _mockRepository;
        private EmployeesController _employeesController;
        public EmployeesControllerTest()
        {
            _mockRepository = new Mock<IEmployeeRepository>();
            _employeesController = new EmployeesController(_mockRepository.Object);
        }   
        
        [Fact]
        public void Index_ActionExecutes_ReturnsViewForIndex()
        {
            //Preparar
            //Ejecutar
            var result = _employeesController.Index();
            //Comparar

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_ActionExecutes_ReturnsExactNumberOfEmployees()
        {
            //Preparar
            _mockRepository.Setup(repo => repo.GetAll())
            .Returns(new List<Employee>() { new Employee(), new Employee() });

            //Ejecutar
            var result = _employeesController.Index();
            var viewResult = Assert.IsType<ViewResult>(result);
            var employees = Assert.IsType<List<Employee>>(viewResult.Model);

            //Comprobar
            Assert.Equal(2, employees.Count);
        }

        [Fact]
        public void Create_ActionExecutes_ReturnsViewForCreate()
        {
            var result = _employeesController.Create();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Create_InvalidModelState_ReturnsView()
        {
            //Preparar
            _employeesController.ModelState.AddModelError("Name", "Name is required");
            var employee = new Employee { Age = 25, AccountNumber = "255-8547963214-41" };

            //Ejecutar
            var result = _employeesController.Create(employee);

            //Comprobar
            var viewResult = Assert.IsType<ViewResult>(result);
            var testEmployee = Assert.IsType<Employee>(viewResult.Model);
            Assert.Equal(employee.AccountNumber, testEmployee.AccountNumber);
            Assert.Equal(employee.Age, testEmployee.Age);
        }

        //[Fact]
        //public void Create_InvalidModelStateRedirectsIndexAction()
        //{

        //    var employee = new Employee { Age = 25, AccountNumber = "255-8547963214-41" };

        //    //Ejecutar
        //    var result = _employeesController.Create(employee);

        //    //Comprobar
        //    var viewResult = Assert.IsType<ViewResult>(result);
        //    var testEmployee = Assert.IsType<Employee>(viewResult.Model);
        //    Assert.Equal(employee.AccountNumber, testEmployee.AccountNumber);
        //    Assert.Equal(employee.Age, testEmployee.Age);
        //}

    }
}
