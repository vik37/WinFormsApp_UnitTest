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
        [Fact]
        public void Devide_DevideyZero()
        {
            double expected = 0;

            double actual = Calculator.Divide(12, 0);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Substract_SimpleValuesShouldCalculateWithFact()
        {
            double expected = 2;

            double actual = Calculator.Sustract(5, 3);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 3, 1)]
        [InlineData(21, 5.25, 15.75)]
        [InlineData(10,  12, -2)]
        public void Sustract_SimpleValuesShouldCalculateWithTheory(double x, double y, double expected)
        {
            double actual = Calculator.Sustract(x, y);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Multiply_SimpleValuesShouldCalculateWithFact()
        {
            double expected = 30;

            double actual = Calculator.Multiply(5, 6);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 3, 12)]
        [InlineData(2.5, 7, 17.5)]
        [InlineData(-3, 2, -6)]
        public void Multiply_SimpleValuesShouldCalculateWithTheory(double x, double y, double expected)
        {
            double actual = Calculator.Multiply(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
