using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class PasswordCheckerTests
    {
        [TestMethod]
        public void CheckPassword_TooLong_ReturnsFalse()
        {
            Assert.IsFalse(PasswordChecker.CheckPassword("asdfasdfasdfasdfasdfasdf"));
        }
        [TestMethod]
        public void CheckPassword_TooShort_ReturnsFalse()
        {
            Assert.IsFalse(PasswordChecker.CheckPassword("asdf"));
        }
        [TestMethod]
        public void CheckPassword_NoUpperCase_ReturnsFalse()
        {
            Assert.IsFalse(PasswordChecker.CheckPassword("asdfasdf"));
        }
        [TestMethod]
        public void CheckPassword_ContainsWhiteSpace_ReturnsFalse()
        {
            Assert.IsFalse(PasswordChecker.CheckPassword("as aasdf"));
        }
        [TestMethod]
        public void CheckPassword_NoLowerCase_ReturnsFalse()
        {
            Assert.IsFalse(PasswordChecker.CheckPassword("ASDFASDF"));
        }
        [TestMethod]
        public void CheckPassword_SameConsecutive_ReturnsFalse()
        {
            Assert.IsFalse(PasswordChecker.CheckPassword("AASaASDF"));
        }
        [TestMethod]
        public void CheckPassword_NoSpecialCharacters_ReturnsFalse()
        {
            Assert.IsFalse(PasswordChecker.CheckPassword("aASaASDF"));
        }
        [TestMethod]
        public void CheckPassword_GoodPassword_ReturnsTrue()
        {
            Assert.IsTrue(PasswordChecker.CheckPassword("aBcdef12&"));
        }
    }
}
