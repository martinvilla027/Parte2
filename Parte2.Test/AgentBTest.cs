using Parte2.Agents;

namespace Parte2.Test
{
    [TestClass]
    public class AgentBTest
    {
        [TestMethod]
        public void CheckValidHarmonicMediaResult()
        {
            // Arrange
            var numbers = new List<double> { 1.5, 5, 4, 8 };
            var expectedMedia = 3.22;

            // Act
            var agentB = new AgentB();
            var result = agentB.GetMedia(numbers);

            var twoDecimal = Math.Floor(result * 100) / 100;

            // Assert
            Assert.AreEqual(expectedMedia, twoDecimal);
        }

        [TestMethod]
        public void CheckInValidHarmonicMediaResult()
        {
            // Arrange
            var numbers = new List<double> { 1.5, 5, 4, 8, 10.3 };
            var expectedMedia = 1.72;

            // Act
            var agentB = new AgentB();
            var result = agentB.GetMedia(numbers);

            var twoDecimal = Math.Floor(result * 100) / 100;

            // Assert
            Assert.AreNotEqual(expectedMedia, twoDecimal);
        }

        [TestMethod]
        public void CheckEmptyHarmonicMediaNumbers()
        {
            // Arrange
            var numbers = new List<double> { };

            // Act
            var agentB = new AgentB();
            var result = agentB.GetMedia(numbers);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CheckValidStairsResult()
        {
            // Arrange
            var size = 5;

            // Act
            var agentB = new AgentB();
            string result = agentB.GetStairCase(size);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void CheckInValidStairsResult()
        {
            // Arrange
            var size = 0;
            var emptyStair = "";

            // Act
            var agentB = new AgentB();
            string result = agentB.GetStairCase(size);

            // Assert
            Assert.AreEqual(result, emptyStair);
        }
    }
}
