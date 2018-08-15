using Xunit;

namespace Fractions.Tests
{
    public class Fraction_MultiplicationTests
    {
        [Fact]
        public void WhenLeftIsIntegerAndRightIsOne_ShouldReturnLeft()
        {
            // Arrange
            Fraction left = 2;
            Fraction one = 1;

            // Act
            Fraction result = left * one;

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenLeftIsFractionAndRightIsOne_ShouldReturnLeft()
        {
            // Arrange
            var left = new Fraction (2, 3);
            Fraction one = 1;

            // Act
            Fraction result = left * one;

            // Assert
            Assert.Equal(new Fraction(2, 3), result);
        }

        [Fact]
        public void WhenLeftIsFractionAndRightIsZero_ShouldReturnZero()
        {
            // Arrange
            var left = new Fraction (2, 3);
            Fraction zero = 0;

            // Act
            Fraction result = left * zero;

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void WhenLeftAndRightAreIntegers_ShouldReturnMultiplicationAsInteger()
        { 
            // Arrange
            Fraction left = 2;
            Fraction right = 3;

            // Act
            var result = left * right;

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void WhenLeftAndRightAreFractions_ShouldReturnNewFraction()
        {
            // Arrange
            var left = new Fraction(3, 7);
            var right = new Fraction(2, 5);

            // Act
            Fraction result = left * right;

            // Assert
            Assert.Equal(new Fraction(6, 35), result);
        }

        [Fact]
        public void WhenLeftIsNegative_ShouldReturnNewFraction()
        {
            // Arrange
            var left = new Fraction(-1, 2);
            var right = new Fraction(2, 3);

            // Act
            Fraction result = left * right;

            // Assert
            Assert.Equal(new Fraction(-1, 3), result);
        }

        [Fact]
        public void ShouldReturnReducedFraction()
        {
            // Arrange
            var left = new Fraction(2, 3);
            var right = new Fraction(3, 4);

            // Act
            Fraction result = left * right;

            // Assert
            Assert.Equal(new Fraction(1, 2), result);
        }
    }
}
