using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var cal = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = cal.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        //Add test data <-------        
        [InlineData(-1, -1, 0)]
        [InlineData(0, 0, 0)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:           
            //Arrange

            var cal = new Calculator();

            //Act
            var actual = cal.Subtract( minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 3, 9)]//Add test data <-------
        [InlineData(4, 4, 16)]
        public void MultiplyTest(int x, int y, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var cal = new Calculator();

            //Act
            int actual = cal.Multiply(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 1, 3)]//Add test data <-------       
        [InlineData(-4, -4, 1)]
        public void DivideTest(int a, int b, int expected)
        {
            //Arrange
            var cal = new Calculator();

            //Act
            int actual = cal.Divide(a, b);

            //Assert
             Assert.Equal(expected, actual);

        }

    }
}
