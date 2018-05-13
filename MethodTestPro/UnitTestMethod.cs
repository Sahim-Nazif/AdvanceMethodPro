using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdvanceMethodPro;
namespace MethodTestPro
{
    [TestClass]
    public class UnitTestMethod
    {
        [TestMethod]
        public void MultiplyNumbersTestMethod1()
        {
            //Arrange
            int number1 = 50;
            int number2 = 3;
            int expectedResult = 150;
            //Act
            int result = Program.MultiplyNumbers(number1, number2);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
