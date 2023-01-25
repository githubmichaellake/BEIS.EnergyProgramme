using BEIS.EnergyProgramme.Services;
using BEIS.EnergyProgramme.Services.Requests;
using BEIS.EnergyProgramme.Web.Controllers;
using Castle.Core.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEIS.energyProgramme.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_Valid_ExpectIndexServiceToBeExecuted()
        {
            // Arrange

            var mockLogger = new Mock<ILogger<HomeController>>();
            var mockService = new Mock<IndexService>();

            mockService.Setup(x => x.Execute(It.IsAny<IndexRequestModel>()));

            var sut = new HomeController(mockLogger.Object, mockService.Object);

            // Act
            var result = sut.Index();

            // Assert
            mockService.Verify(x => x.Execute(It.IsAny<IndexRequestModel>()));
        }
    }
}
