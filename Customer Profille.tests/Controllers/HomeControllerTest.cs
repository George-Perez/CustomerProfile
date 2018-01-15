using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerProfile.Controllers;
using System.Web.Mvc;
using CustomerProfile.Models;

namespace CustomerProfille.tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            //ViewResult result = (ViewResult)Controller.Index();
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            //Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);

            

        }

        [TestMethod]
        public void About()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.About() as ViewResult;

            Assert.AreEqual(result.ViewData["Hello"], "Response Data");

        }

        [TestMethod]
        public void Contact()
        {
            HomeController controller = new HomeController();

            CustomerProfileModel employee = new CustomerProfileModel {

            };

            ViewResult result = controller.Contact(employee) as ViewResult;

            Assert.AreEqual("Suspend", result.ViewData["EmployeeStatus"]);
            Assert.AreEqual(false, result.ViewData["EmployeePromoted"]);

        }
    }
}
