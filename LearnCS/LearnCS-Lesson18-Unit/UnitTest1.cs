using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson18;

namespace Lesson18_Unit
{
    [TestClass]
    public class ExtensionMethodsPlusFiveShould
    {
        [TestMethod]
        public void ReturnFiveMoreThanInput()
        {
            //Arrange
            int input = 10;
            int expectedResult = 0;

            //Act
            int actualResult = input.PlusFive();

            //Assert
            Assert.AreEqual(expectedResult,actualResult);

        }

        [TestMethod]
        public void ReturnFiveEqualsThanInput()
        {
            //Arrange
            int input = 10;
            int expectedResult = 15;

            //Act
            int actualResult = input.PlusFive();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
