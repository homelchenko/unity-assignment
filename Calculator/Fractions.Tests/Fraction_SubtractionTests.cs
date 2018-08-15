using Xunit;

namespace Fractions.Tests
{
    public class Fraction_SubtractionTests
    {
        [Fact]
        public void WhenLeftIsIntegerAndRightIsZero_ShouldReturnLeft()
        {
            // Arrange
            var left = new Fraction(2);
            var zeroRight = new Fraction(0);

            // Act
            Fraction result = left - zeroRight;

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenLeftIsFractionAndRightIsZero_ShouldReturnLeft()
        {
            // Arrange
            var left = new Fraction(2, 3);
            var zeroRight = new Fraction(0);

            // Act
            Fraction result = left - zeroRight;

            // Assert
            Assert.Equal(new Fraction(2, 3), result);
        }
    }
}
