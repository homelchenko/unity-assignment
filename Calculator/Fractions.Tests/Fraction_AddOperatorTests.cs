using Xunit;

namespace Fractions.Tests
{
    public class Fraction_AddOperatorTests
    {
        [Fact]
        public void AddOperator_WhenRightFractionIsZero_ShouldReturnLeft()
        {
            // Arrange
            var left = new Fraction(3);
            var zero = new Fraction(0);

            // Act
            Fraction result = left + zero;

            // Assert
            Assert.Equal(3, result);
        }

        
    }
}
