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

        [Fact]
        public void WhenLeftAndRightAreIntegers_ShouldReturnMultiplicationAsInteger()
        { 
            // Arrange
            var left = new Fraction(2);
            var right = new Fraction(3);

            // Act
            var result = left * right;

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void WhenLeftAndRightAreFractions_ShouldReturnNewFraction()
        {
            // Arrange
            var left = new Fraction(3, 5);
            var right = new Fraction(2, 3);

            // Act
            Fraction result = left * right;

            // Assert
            Assert.Equal(new Fraction(6, 15), result);
        }
    }
}
