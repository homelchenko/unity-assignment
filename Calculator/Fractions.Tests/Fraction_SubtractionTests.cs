using Xunit;

namespace Fractions.Tests
{
    public class Fraction_SubtractionTests
    {
        [Fact]
        public void WhenLeftIsIntegerAndRightIsZero_ShouldReturnLeft()
        {
            // Arrange
            Fraction left = 2;
            Fraction zero = 0;

            // Act
            Fraction result = left - zero;

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenLeftIsFractionAndRightIsZero_ShouldReturnLeft()
        {
            // Arrange
            var left = new Fraction(2, 3);
            Fraction zero = 0;

            // Act
            Fraction result = left - zero;

            // Assert
            Assert.Equal(new Fraction(2, 3), result);
        }

        [Fact]
        public void WhenLeftIsZeroAndRightIsFraction_ShouldReturnOppositeOfRight()
        {
            // Arrange
            Fraction zero = 0;
            var right = new Fraction(2, 3);

            // Act
            Fraction result = zero - right;

            // Assert
            Assert.Equal(new Fraction(-2, 3), result);
        }

        [Fact]
        public void WhenBothLeftAndRightAreIntegers_ShouldReturnDifferenceAsInteger()
        {
            // Arrange
            Fraction left = 3;
            Fraction right = 2;

            // Act
            Fraction result = left - right;

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void WhenBothLeftAndRightAreFractionsWithSameDenominator_ShouldReturnNewFractionWithDifferenceOfNumeratorsAndSameDenominator()
        {
            // Arrange
            var left = new Fraction(3, 5);
            var right = new Fraction(1, 5);

            // Act
            Fraction result = left - right;

            // Assert
            Assert.Equal(new Fraction(2, 5), result);
        }

        [Fact]
        public void WhenBothLeftAndRightAreFractionsWithDifferentDenominators_ShouldReturnNewFraction()
        {
            // Arrange
            var left = new Fraction(1, 2);
            var right = new Fraction(1, 4);

            // Act
            Fraction result = left - right;

            // Assert
            Assert.Equal(new Fraction(1, 4), result);
        }

        [Fact]
        public void WhenBothLeftAndRightAreSimpleFractionsWithDifferentDenominators_ShouldReturnNewFraction()
        {
            // Arrange
            var left = new Fraction(3, 7);
            var right = new Fraction(2, 5);

            // Act
            Fraction result = left - right;

            // Assert
            Assert.Equal(new Fraction(1, 35), result);
        }

        [Fact]
        public void WhenBothLeftAndRightAreFractionsWithDifferentDenominators_ShouldReturnNewSimplifiedFraction()
        {
            // Arrange
            var left = new Fraction(3, 4);
            var right = new Fraction(1, 4);

            // Act
            Fraction result = left - right;

            // Assert
            Assert.Equal(new Fraction(1, 2), result);
        }

        [Fact]
        public void WhenBothLeftAndRightAreNegativeFractionsWithDifferentDenominators_ShouldReturnNewSimplifiedFraction()
        {
            // Arrange
            var left = new Fraction(-2, 4);
            var right = new Fraction(1, -4);

            // Act
            Fraction result = left - right;

            // Assert
            Assert.Equal(new Fraction(-1, 4), result);
        }
    }
}
