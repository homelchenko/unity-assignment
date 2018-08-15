using Xunit;

namespace Fractions.Tests
{
    public class Fraction_EqualityTests
    {
        [Fact]
        public void Equals_WhenEqualIntegers_ShouldReturnTrue()
        {
            // Arrange
            var left = new Fraction(1);
            var right = new Fraction(1);

            // Act
            bool isEqual = left.Equals(right);

            // Assert
            Assert.True(isEqual);
        }

        [Fact]
        public void Equals_WhenDifferentIntegers_ShouldReturnFalse()
        {
            // Arrange
            var left = new Fraction(2);
            var right = new Fraction(3);

            // Act
            bool isEqual = left.Equals(right);

            // Assert
            Assert.False(isEqual);
        }

        [Fact]
        public void Equals_WhenNumeratorsEqualAndDenominatorsDifferent_ShouldReturnFalse()
        {
            // Arrange
            var left = new Fraction(1, 2);
            var right = new Fraction(1, 3);

            // Act
            bool isEqual = left.Equals(right);

            // Assert
            Assert.False(isEqual);
        }

        [Fact]
        public void Equals_WhenNumeratorsAndDenominatorsEqual_ShouldReturnTrue()
        {
            // Arrange
            var left = new Fraction(1, 2);
            var right = new Fraction(1, 2);

            // Act
            bool isEqual = left.Equals(right);

            // Assert
            Assert.True(isEqual);
        }

        [Fact]
        public void Equals_WhenSameValue_ShouldReturnTrue()
        {
            // Arrange
            var value = new Fraction(1, 1);

            // Act
            bool isEqual = value.Equals(value);

            // Assert
            Assert.True(isEqual);
        }

        [Fact]
        public void Equals_WhenDifferentType_ShouldReturnFalse()
        {
            // Arrange
            var value = new Fraction(1);

            var otherObject = new object();

            // Act
            bool isEqual = value.Equals(otherObject);

            // Assert
            Assert.False(isEqual);
        }

        [Fact]
        public void Equals_WhenOtherValueIsNull_ShouldReturnFalse()
        {
            // Arrange
            var value = new Fraction(1);

            object nullValue = null;

            // Act
            bool isEqual = value.Equals(nullValue);

            // Assert
            Assert.False(isEqual);
        }

        [Fact]
        public void GetHashCode_WhenSameValues_ShouldBeSameHashCodes()
        {
            // Arrange
            var left = new Fraction(1, 5);
            var right = new Fraction(1, 5);

            // Act
            int hashCode = right.GetHashCode();

            // Assert
            Assert.Equal(hashCode, left.GetHashCode());
        }

        [Fact]
        public void GetHashCode_WhenNumeratorsAreSlightlyDifferent_ShoulHashCodesBeDifferent()
        {
            // Arrange
            var left = new Fraction(2, 5);
            var right = new Fraction(1, 5);

            // Act
            int hashCode = right.GetHashCode();

            // Assert
            Assert.NotEqual(hashCode, left.GetHashCode());
        }

        [Fact]
        public void GetHashCode_WhenDenominatorsAreSlightlyDifferent_ShoulHashCodesBeDifferent()
        {
            // Arrange
            var left = new Fraction(1, 1);
            var right = new Fraction(1, 2);

            // Act
            int hashCode = right.GetHashCode();

            // Assert
            Assert.NotEqual(hashCode, left.GetHashCode());
        }

        [Fact]
        public void EqualOperator_WhenNominatorsAreDenominatorsSame_ShouldReturnTrue()
        {
            // Arrange
            var left = new Fraction(1, 2);
            var right = new Fraction(1, 2);

            // Act
            bool isEqual = left == right;

            // Assert
            Assert.True(isEqual);
        }

        [Fact]
        public void EqualOperator_WhenNominatorsAreDenominatorsDifferent_ShouldReturnFalse()
        {
            // Arrange
            var left = new Fraction(1, 2);
            var right = new Fraction(3, 4);

            // Act
            bool isEqual = left == right;

            // Assert
            Assert.False(isEqual);
        }

        [Fact]
        public void InequalOperator_WhenNominatorsAreDenominatorsSame_ShouldReturnFalse()
        {
            // Arrange
            var left = new Fraction(1, 2);
            var right = new Fraction(1, 2);

            // Act
            bool isEqual = left != right;

            // Assert
            Assert.False(isEqual);
        }


        [Fact]
        public void InequalOperator_WhenNominatorsAreDenominatorsSame_ShouldReturnTrue()
        {
            // Arrange
            var left = new Fraction(1, 2);
            var right = new Fraction(3, 4);

            // Act
            bool isEqual = left != right;

            // Assert
            Assert.True(isEqual);
        }
    }
}
