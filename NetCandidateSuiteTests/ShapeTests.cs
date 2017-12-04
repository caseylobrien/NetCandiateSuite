using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCandidateSuite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCandidateSuiteTests
{
    [TestClass]
    public class ShapeTests
    {
        #region Shape Class Tests
        [TestMethod]
        public void ShapeGetDescriptionCorrectResult()
        {
            var sides = 5;
            var shape = new Shape(sides);
            var expectedResult = String.Format("{0}: I have {1} sides!", shape.GetType().ToString(), sides);

            var result = shape.GetDescription();

            Assert.IsTrue(String.Equals(expectedResult, result));
        }
        #endregion

        #region Circle Tests
        [TestMethod]
        public void CircleGetDescriptionCorrectResponse()
        {
            // Arrange

            // Act

            // Assert
        }
        #endregion
    }
}
