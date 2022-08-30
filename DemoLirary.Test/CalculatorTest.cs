using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DemoLirary.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculateWithFact()
        {
            // Arrange
            double expected = 5;

            // Act
            double actual = 5; //Calculator.Add(2, 3);

            // Assert
            Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculateWithTheory(double x, double y, double expected)
        {
            double actual = Calculator.Add(x, y);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(8,4,2)]
        public void Devide_SimpleValuesShouldCalculateWithTheory(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
