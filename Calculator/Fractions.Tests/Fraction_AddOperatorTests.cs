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
    }
}
