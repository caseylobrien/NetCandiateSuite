using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCandidateSuite;
using System;

namespace NetCandidateSuiteTests
{
    [TestClass]
    public class StringManipulationTests
    {
        #region GetChatAt Tests
        [TestMethod]
        public void GetCharAtThrowArgumentNullExceptionForEmptyInput()
        {
            Action action = () => StringManipulation.GetCharAt(String.Empty, 1);

            Assert.ThrowsException<ArgumentNullException>(action);
        }

        [TestMethod]
        public void GetCharAtThrowArgumentNullExceptionForNullInput()
        {
            Action action = () => StringManipulation.GetCharAt(null, 1);

            Assert.ThrowsException<ArgumentNullException>(action);
        }

        [TestMethod]
        public void GetCharAtThrowArgumentOutOfRangeExceptionWhereCharAtZero()
        {
            Action action = () => StringManipulation.GetCharAt("hello", 0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(action);
        }

        [TestMethod]
        public void GetCharAtThrowArgumentOutOfRangeExceptionWhereCharAtNegative()
        {
            Action action = () => StringManipulation.GetCharAt("hello", -4);

            Assert.ThrowsException<ArgumentOutOfRangeException>(action);
        }

        [TestMethod]
        public void GetCharAtReturnsFirstCharacter()
        {
            var result =  StringManipulation.GetCharAt("hello", 1);

            Assert.AreEqual(result, 'h');
        }

        [TestMethod]
        public void GetCharAtReturnsFirstCharacterLoops()
        {
            var result = StringManipulation.GetCharAt("hello", 11);

            Assert.AreEqual(result, 'h');
        }

        [TestMethod]
        public void GetCharAtReturnsLastCharacter()
        {
            var result = StringManipulation.GetCharAt("hello", 5);

            Assert.AreEqual(result, 'o');
        }

        [TestMethod]
        public void GetCharAtReturnsLastCharacterLoops()
        {
            var result = StringManipulation.GetCharAt("hello", 20);

            Assert.AreEqual(result, 'o');
        }

        [TestMethod]
        public void GetCharAtReturnsMiddleCharacter()
        {
            var result = StringManipulation.GetCharAt("hello", 2);

            Assert.AreEqual(result, 'e');
        }

        [TestMethod]
        public void GetCharAtReturnsMiddleCharacterLoops()
        {
            var result = StringManipulation.GetCharAt("hello", 102);

            Assert.AreEqual(result, 'e');
        }
        #endregion

        #region ReverseWithDash Tests
        [TestMethod]
        public void ReverseWithDashThrowsArgumentNullExceptionForNullInput()
        {
            Action action = () => StringManipulation.ReverseWithDash(null);

            Assert.ThrowsException<ArgumentNullException>(action);
        }

        [TestMethod]
        public void ReverseWithDashThrowsArgumentNullExceptionForEmptyInput()
        {
            Action aciton = () => StringManipulation.ReverseWithDash(String.Empty);

            Assert.ThrowsException<ArgumentNullException>(aciton);
        }

        [TestMethod]
        public void ReverseWithDashCorrectResultSingleWord()
        {
            var input = "hello";

            var result = StringManipulation.ReverseWithDash(input);

            Assert.IsTrue(String.Equals(result, "o-l-l-e-h"));
        }

        [TestMethod]
        public void ReverseWithDashCorrectResultMultipleWords()
        {
            var input = "test with multiple words";
            var expectedResult = "s-d-r-o-w- -e-l-p-i-t-l-u-m- -h-t-i-w- -t-s-e-t";

            var result = StringManipulation.ReverseWithDash(input);

            Assert.IsTrue(String.Equals(result, expectedResult));
        }
        #endregion
    }
}
