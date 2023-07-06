using Parte2.Agents;

namespace Parte2.Test
{
    [TestClass]
    public class AgentATest
    {
        [TestMethod]
        public void CheckValidMediaResult()
        {
            // Arrange
            var numbers = new List<double> { 1, 2, 3 };
            var expectedMedia = 2;

            // Act
            var agentA = new AgentA();
            var result = agentA.GetMedia(numbers);

            // Assert
            Assert.AreEqual(expectedMedia, result);
        }

        [TestMethod]
        public void CheckInValidMediaResult()
        {
            // Arrange
            var numbers = new List<double> { 8, 1, 3 };
            var expectedMedia = 3;

            // Act
            var agentA = new AgentA();
            var result = agentA.GetMedia(numbers);

            // Assert
            Assert.AreNotEqual(expectedMedia, result);
        }

        [TestMethod]
        public void CheckEmptyMediaNumbers()
        {
            // Arrange
            var numbers = new List<double> { };

            // Act
            var agentA = new AgentA();
            var result = agentA.GetMedia(numbers);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CheckValidStairsResult()
        {
            // Arrange
            var size = 4;

            // Act
            var agentA = new AgentA();
            string result = agentA.GetStairCase(size);

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
            var agentA = new AgentA();
            string result = agentA.GetStairCase(size);

            // Assert
            Assert.AreEqual(result, emptyStair);
        }
    }
}