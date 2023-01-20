using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System;

namespace BEIS.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var service = null;
            var sut = new HomeController(Logger, service);

            // Act
            var result = sut.Index();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
