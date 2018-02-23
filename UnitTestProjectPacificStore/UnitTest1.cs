using Microsoft.VisualStudio.TestTools.UnitTesting;
using PacificStore.Models;
using System.Data.Entity;
using Moq;
using PacificStore.Controllers;
using System.Web.Mvc;
using System;

namespace UnitTestProjectPacificStore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockSetCustomer = new Mock<DbSet<Customer>>();
            var mockContext = new Mock<ApplicationDbContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSetCustomer.Object);
            var customerController = new CustomersController(mockContext.Object);
            ActionResult result = customerController.Edit(1) as ViewResult;
            Assert.ThrowsException<NotSupportedException>(() => result);
        }
    }
}
