using DonutWisdomService;

namespace DonutWisdomServiceTests
{
    /// <summary>
    /// Tests for the Service1 class, ensuring the donut wisdom functionality.
    /// </summary>
    public class ServiceTests
    {
        /// <summary>
        /// Verifies that the GetWordsOfWisdom method always returns a string result.
        /// </summary>
        [Fact]  
        public void GetWordsOfWisdom_AlwaysReturnsString()
        {
            // Arrange
            var service = new Service1();

            // Act
            var result = service.GetWordsOfWisdom();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<string>(result);  // Or Assert.IsAssignableFrom<string>(result);
        }

        /// <summary>
        /// Tests that the GetWordsOfWisdom method never returns an empty string.
        /// </summary>
        [Fact]
        public void GetWordsOfWisdom_NeverReturnsEmpty()
        {
            var service = new Service1();
            var result = service.GetWordsOfWisdom();

            Assert.NotEmpty(result); // Ensures there's always some wisdom!
        }
    }
}