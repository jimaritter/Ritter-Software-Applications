using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaticConsulting.Model.Products;
using StaticConsulting.Web.Controllers;
using Web;

namespace Web.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            IProduct product = new Product();
            // Arrange
            HomeController controller = new HomeController(product);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Static Consulting - Software Consulting", result.ViewBag.Message);
        }

        [TestMethod]
        public void About()
        {
            IProduct product = new Product();
            // Arrange
            HomeController controller = new HomeController(product);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact()
        {
            IProduct product = new Product();
            // Arrange
            HomeController controller = new HomeController(product);

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
