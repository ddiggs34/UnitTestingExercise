using System;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(11, 3, 9, 23)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var addTest = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = addTest.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);

            Assert.Equal(expected, actual); 
        }

        [Theory]
        [InlineData(40, 22, 18)]
        [InlineData(12, 3, 18)]
        //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtractTest = new Calculator();
            //Act
            var actual = subtractTest.Subtract(minuend, subtrhend);
            //Assert

        }

        [Theory]
        [InlineData(2, 10, 20)]
        [InlineData(2, 2, 4)]
        //Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multiplyTest = new Calculator();
            //Act
            var actual = multiplyTest.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 2, 10)]
        [InlineData(30, 10, 3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divideTest = new Calculator();
            //Act
            var actual = divideTest.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
