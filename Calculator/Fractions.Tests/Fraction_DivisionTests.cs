using System;
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

        [Fact]
        public void WhenBothLeftAndRightAreSimpleIntegers_ShouldReturnNewFraction()
        { 
            // Arrange
            Fraction left = 2;
            Fraction right = 3;

            // Act
            Fraction result = left / right;

            // Assert
            Assert.Equal(new Fraction(2, 3), result);
        }

        [Fact]
        public void WhenBothLeftAndRightAreIntegersWithCommonDenominator_ShouldReturnNewReducedFraction()
        { 
            // Arrange
            Fraction left = 2;
            Fraction right = 4;

            // Act
            Fraction result = left / right;

            // Assert
            Assert.Equal(new Fraction(1, 2), result);
        }

        [Fact]
        public void WhenBothLeftAndRightAreFractions_ShouldReturnNewFraction()
        { 
            // Arrange
            Fraction left = new Fraction(1, 2);
            Fraction right = new Fraction(3, 5);

            // Act
            Fraction result = left / right;

            // Assert
            Assert.Equal(new Fraction(5, 6), result);
        }

        [Fact]
        public void WhenBothLeftAndRightAreFractionsWithCommonDenominators_ShouldReturnNewFraction()
        { 
            // Arrange
            Fraction left = new Fraction(3, 2);
            Fraction right = new Fraction(9, 4);

            // Act
            Fraction result = left / right;

            // Assert
            Assert.Equal(new Fraction(2, 3), result);
        }

        [Fact]
        public void WhenRightIsZero_ShouldThrow()
        { 
            // Arrange
            var left = new Fraction(2, 3);
            Fraction zero = 0;

            Action divide = () =>
            {
                var result = left / zero;
            };

            // Act & Assert
            Assert.Throws<DivideByZeroException>(divide);
        }
    }
}
