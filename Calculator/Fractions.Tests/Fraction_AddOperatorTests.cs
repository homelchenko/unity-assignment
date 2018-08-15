using Xunit;

namespace Fractions.Tests
{
    public class Fraction_AddOperatorTests
    {
        [Fact]
        public void AddOperator_WhenLeftIsIntegerAndRightFractionIsZero_ShouldReturnLeft()
        {
            // Arrange
            var left = new Fraction(3);
            var zero = new Fraction(0);

            // Act
            Fraction result = left + zero;

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddOperator_WhenLeftIsFractionAndRightFractionIsZero_ShouldReturnLeft()
        {
            // Arrange
            var left = new Fraction(3, 2);
            var zero = new Fraction(0);

            // Act
            Fraction result = left + zero;

            // Assert
            Assert.Equal(new Fraction(3, 2), result);
        }

        [Fact]
        public void AddOperator_WhenBothLeftAndRightAreIntegers_ShouldReturnSumAsInteger()
        {
            // Arrange
            var left = new Fraction(3);
            var right = new Fraction(2);

            // Act
            Fraction result = left + right;

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void AddOperator_WhenBothLeftAndRightAreFractionsWithSameDenominator_ShouldReturnNewFractionWithSumOfNominatorsAndSameDenominator()
        {
            // Arrange
            var left = new Fraction(1, 5);
            var right = new Fraction(2, 5);

            // Act
            Fraction result = left + right;

            // Assert
            Assert.Equal(new Fraction(3, 5), result);
        }

        [Fact]
        public void AddOperator_WhenBothLeftAndRightAreFractionsWithDifferentDenominators_ShouldReturnNewFraction()
        {
            // Arrange
            var left = new Fraction(1, 2);
            var right = new Fraction(1, 4);

            // Act
            Fraction result = left + right;

            // Assert
            Assert.Equal(new Fraction(3, 4), result);
        }

        [Fact]
        public void AddOperator_WhenBothLeftAndRightAreSimpleFractionsWithDifferentDenominators_ShouldReturnNewFraction()
        {
            // Arrange
            var left = new Fraction(2, 5);
            var right = new Fraction(3, 7);

            // Act
            Fraction result = left + right;

            // Assert
            Assert.Equal(new Fraction(29, 35), result);
        }
    }
}
