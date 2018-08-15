using Xunit;

namespace Fractions.Tests
{
    public class Fraction_ConversionsTests
    {
        [Fact]
        public void ImplicitConverstionFromInteger_ShouldReturnIntegerFraction()
        {
            // Act
            Fraction result = 3;

            // Assert
            Assert.Equal(new Fraction(3, 1), result);
        }
    }
}
