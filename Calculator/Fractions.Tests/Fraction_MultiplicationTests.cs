using Xunit;

namespace Fractions.Tests
{
    public class Fraction_MultiplicationTests
    {
        [Fact]
        public void WhenLeftIsIntegerAndRightIsOne_ShouldReturnLeft()
        {
            // Arrange
            var left = new Fraction (2);
            var oneRight = new Fraction(1);

            // Act
            Fraction result = left * oneRight;

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenLeftIsFractionAndRightIsOne_ShouldReturnLeft()
        {
            // Arrange
            var left = new Fraction (2, 3);
            var oneRight = new Fraction(1);

            // Act
            Fraction result = left * oneRight;

            // Assert
            Assert.Equal(new Fraction(2, 3), result);
        }
    }
}
