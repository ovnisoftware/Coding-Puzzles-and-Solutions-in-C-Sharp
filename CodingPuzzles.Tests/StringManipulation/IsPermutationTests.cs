using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class IsPermutationTests
    {
        [TestMethod]
        public void PermutationCheck_PassedPermutations_ReturnsTrue()
        {
            Assert.IsTrue(IsPermutation.PermutationCheck("cat", "tac"));
        }
        [TestMethod]
        public void PermutationCheck_PassedNonPermutationsOfDifferentLength_ReturnsFalse()
        {
            Assert.IsFalse(IsPermutation.PermutationCheck("asdf", "tac"));
        }
        [TestMethod]
        public void PermutationCheck_PassedNonPermutationsOfSameLength_ReturnsFalse()
        {
            Assert.IsFalse(IsPermutation.PermutationCheck("asd", "tac"));
        }
        [TestMethod]
        public void PermutationCheck_PassedTwoEmptyStrings_ReturnsTrue()
        {
            Assert.IsTrue(IsPermutation.PermutationCheck("", ""));
        }
        [TestMethod]
        public void PermutationCheck_PassedOneEmptyString_ReturnsFalse()
        {
            Assert.IsFalse(IsPermutation.PermutationCheck("", "tac"));
        }
    }
}
