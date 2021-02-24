using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionExplorerDemo;

namespace SolutionExplorerDemo_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CurrentStatus_NullPaidUptoDate_TemporaryStatus()
        {
            //Arrange
            Customer customer = new Customer();
            customer.PaidUpTo = null;

            //Action
            var status= customer.CurrentStatus;

            //Assert
            //Assert.Inconclusive();
            Assert.AreEqual(status,Status.Temporary);
        }
    }
}
