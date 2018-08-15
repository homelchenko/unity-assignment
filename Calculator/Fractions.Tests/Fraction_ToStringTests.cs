using Xunit;

namespace Fractions.Tests
{
    public class Fraction_ToStringTests
    {
        [Fact]
        public void ShouldIncludeBothNumeratorAndDenominator()
        {
            // Arrange
            var value = new Fraction(1, 2);

            // Act
            string result = value.ToString();

            // Assert
            Assert.Equal("1 / 2", result);
        }

        [Fact]
        public void WhenNumeratorIsZero_ShouldReturnZero()
        {
            // Arrange
            var value = new Fraction(0, 2);

            // Act
            string result = value.ToString();

            // Assert
            Assert.Equal("0", result);
        }

        [Fact]
        public void WhenDenumeratorIsOne_ShouldReturnNumerator()
        {
            // Arrange
            var value = new Fraction(2, 1);

            // Act
            string result = value.ToString();

            // Assert
            Assert.Equal("2", result);
        }

        [Fact]
        public void WhenIntegerZero_ShouldReturnZero()
        {
            // Arrange
            var value = new Fraction(0);

            // Act
            string result = value.ToString();

            // Assert
            Assert.Equal("0", result);
        }
    }
}
