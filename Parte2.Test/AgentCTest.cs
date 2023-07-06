using Parte2.Agents;

namespace Parte2.Test
{
    [TestClass]
    public class AgentCTest
    {
        [TestMethod]
        public void CheckEvenNumberMediaResult()
        {
            // Arrange
            var numbers = new List<double> { 2, 5, 9, 8 };
            var expectedMedia = 9;

            // Act
            var agentC = new AgentC();
            var result = agentC.GetMedia(numbers);

            // Assert
            Assert.AreEqual(expectedMedia, result);
        }

        [TestMethod]
        public void CheckOddNumberMediaResult()
        {
            // Arrange
            var numbers = new List<double> { 7, 5, 4, 8, 3 };
            var expectedMedia = 5;

            // Act
            var agentC = new AgentC();
            var result = agentC.GetMedia(numbers);

            // Assert
            Assert.AreEqual(expectedMedia, result);
        }

        [TestMethod]
        public void CheckEmptyMediaNumbers()
        {
            // Arrange
            var numbers = new List<double> { };

            // Act
            var agentC = new AgentB();
            var result = agentC.GetMedia(numbers);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CheckValidDiamondStairsResult()
        {
            // Arrange
            var size = 5;

            // Act
            var agentC = new AgentC();
            string result = agentC.GetStairCase(size);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void CheckInValidDiamondStairsResult()
        {
            // Arrange
            var size = 0;
            var emptyStair = "";

            // Act
            var agentC = new AgentC();
            string result = agentC.GetStairCase(size);

            // Assert
            Assert.AreEqual(result, emptyStair);
        }
    }
}
