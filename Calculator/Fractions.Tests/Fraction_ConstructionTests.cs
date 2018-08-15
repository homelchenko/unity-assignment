using System;
using Xunit;

namespace Fractions.Tests
{
    public class Fraction_ConstructionTests
    {
        [Fact]
        public void WhenDenominatorIsZero_ShouldThrow()
        {
            // Arrange
            int anyInteger = 3;
            
            Action construct = () => new Fraction(anyInteger, 0);

            // Act & Assert
            Assert.Throws<DivideByZeroException>(construct);
        }

        [Fact]
        public void WhenDenominatorIsNegative_ShouldSwitchToPositive()
        { 
            // Act
            var fraction = new Fraction(1, -3);

            // Asesrt
            Assert.Equal("-1 / 3", fraction.ToString());
        }

        [Fact]
        public void WhenDenominatorIsPositive_ShouldLeaveAsIs()
        { 
            // Act
            var fraction = new Fraction(1, 3);

            // Asesrt
            Assert.Equal("1 / 3", fraction.ToString());
        }
    }
}
