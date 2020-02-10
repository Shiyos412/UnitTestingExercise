using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods myTests = new UnitTestMethods();
            //Act
            int result = myTests.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10,5,5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var myTests = new UnitTestMethods();
            //Act
            int result = myTests.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5,2,10)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var myTests = new UnitTestMethods();
            //Act
            int result = myTests.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10,5,2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var myTests = new UnitTestMethods();
            //Act
            int result = myTests.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Pie()
        {
            //Arrange
            var myTests = new UnitTestMethods();
            //Act
            double result = Math.PI;
            //Assert
            Assert.Equal(result, myTests.Pie());

        }

        [Fact]
        public void Below10Above0()
        {
            //Arrange
            var myTests = new UnitTestMethods();
            //Act
            int[] result = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //Assert
            Assert.Equal(result, myTests.Below10Above0());
        }
    }
}
