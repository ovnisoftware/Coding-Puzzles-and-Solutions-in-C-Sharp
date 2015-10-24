using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class LengthOfLastWordTests
    {
        [TestMethod]
        public void GetLength_PassedStringWithNoLastWord_ReturnsZero()
        {
            Assert.AreEqual(0, LengthOfLastWord.GetLength("abc abc abc abce "));
        }
        [TestMethod]
        public void GetLength_PassedStringWith4CharacterLastWord_Returns4()
        {
            Assert.AreEqual(4, LengthOfLastWord.GetLength("abc abc abc abce"));
        }
        [TestMethod]
        public void GetLength_PassedStringWith2CharacterLastWord_Returns2()
        {
            Assert.AreEqual(2, LengthOfLastWord.GetLength("abc abc abc ab"));
        }
        [TestMethod]
        public void GetLength2_PassedStringWithNoLastWord_ReturnsZero()
        {
            Assert.AreEqual(0, LengthOfLastWord.GetLength2("abc abc abc abce "));
        }
        [TestMethod]
        public void GetLength2_PassedStringWith4CharacterLastWord_Returns4()
        {
            Assert.AreEqual(4, LengthOfLastWord.GetLength2("abc abc abc abce"));
        }
        [TestMethod]
        public void GetLength2_PassedStringWith2CharacterLastWord_Returns2()
        {
            Assert.AreEqual(2, LengthOfLastWord.GetLength2("abc abc abc ab"));
        }
    }
}
