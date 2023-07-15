using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraySplitCodingChallenge_CH;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Array_ValidSize()
        {
            ArrayController array = new ArrayController(10, 2);

            int expected = 10;

            Assert.AreEqual(expected, array.Array.Length);
        }

        [TestMethod]
        public void Array_ThrowArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => CreateOutOfBoundsArray());
        }

        [TestMethod]
        public void DivisibleNumber_ThrowArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => CreateOutOfBoundsDivision());
        }

        [TestMethod]
        public void Array_CheckBlankResults()
        {
            ArrayController array = new ArrayController(0, 1);
            string expected = "[ [] ]";

            Assert.AreEqual(expected, array.GroupArrayElementsAndPrint());
        }

        [TestMethod]
        public void Array_CheckSize3Results()
        {
            ArrayController array = new ArrayController(3, 2);
            string expected = "[ [1, 2], [3] ]";

            Assert.AreEqual(expected, array.GroupArrayElementsAndPrint());
        }

        [TestMethod]
        public void Array_CheckSize3Results_NoDivision()
        {
            ArrayController array = new ArrayController(3, 1);
            string expected = "[ [1, 2, 3] ]";

            Assert.AreEqual(expected, array.GroupArrayElementsAndPrint());
        }

        [TestMethod]
        public void Array_PassPrepopulatedAndDivide()
        {
            ArrayController array = new ArrayController(new int[] { 1, 2, 3, 4, 5 }, 3);
            string expected = "[ [1, 2], [3, 4], [5] ]";

            Assert.AreEqual(expected, array.GroupArrayElementsAndPrint());
        }

        public void CreateOutOfBoundsArray()
        {
            ArrayController array = new ArrayController(-1, 1);
        }

        public void CreateOutOfBoundsDivision()
        {
            ArrayController array = new ArrayController(5, 0);
        }
    }
}
