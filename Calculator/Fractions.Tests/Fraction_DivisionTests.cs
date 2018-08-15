using Xunit;

namespace Fractions.Tests
{
    public class Fraction_DivisionTests
    {
        [Fact]
        public void WhenLeftIsIntegerAndRightIsOne_ShouldReturnLeft()
        { 
            // Arrange
            var left = new Fraction(2);
            Fraction one = 1;

            // Act
            Fraction result = left / one;

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenLeftIsFractionAndRightIsOne_ShouldReturnLeft()
        { 
            // Arrange
            var left = new Fraction(2, 3);
            Fraction one = 1;

            // Act
            Fraction result = left / one;

            // Assert
            Assert.Equal(new Fraction(2, 3), result);
        }

    }
}
