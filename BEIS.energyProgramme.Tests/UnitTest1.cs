using BEIS.EnergyProgramme.Services;
using BEIS.EnergyProgramme.Services.Requests;

namespace BEIS.energyProgramme.Tests
{
    [TestClass]
    public class IndexServiceTests
    {
        [TestMethod]
        public void Execute_Ben_ExpectSuccess() // postive
        {
            // Arrange 
            var expected = "We know its you Ben";

            var sut = new IndexService(expected);
            var validModel = new IndexRequestModel
            {
                Name = "Ben"
            };

            // Act
            var result = sut.Execute(validModel);

            // Assert
            Assert.AreEqual(expected, result.Message);
        }

        [TestMethod]
        public void Execute_Other_ExpectSuccess() // postive
        {
            // Arrange 
            var name = "Other";

            var sut = new IndexService("NonStandard");
            var validModel = new IndexRequestModel
            {
                Name = name
            };

            // Act
            var result = sut.Execute(validModel);

            // Assert
            Assert.AreEqual($"hello {name}", result.Message);
        }

        [TestMethod]
        public void Execute_InvalidModel_ExpectFailure() // negative
        {
            // Arrange 
            var expected = "We know its you Ben";

            var sut = new IndexService(expected);
            var validModel = new IndexRequestModel
            {
                Name = string.Empty
            };

            // Act
            var result = sut.Execute(validModel);

            // Assert
            Assert.AreNotEqual(expected, result.Message);
        }

        [TestMethod]
        public void Execute_InvalidModel_ExpectException() // negative
        {
            // Arrange 
            var sut = new IndexService(string.Empty);
        
            // Act
            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => sut.Execute(null));
        }
    }
}