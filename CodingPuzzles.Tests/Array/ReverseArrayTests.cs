using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class ReverseArrayTests
    {
        [TestMethod]
        public void Reverse_1234Passed_Returns4321()
        {
            int[] input = new int[] { 1, 2, 3, 4 };
            ReverseArray.Reverse(input);
            int[] correct = new int[] { 4, 3, 2, 1 };
            CollectionAssert.AreEqual(correct, input);
        }
        [TestMethod]
        public void Reverse_EmptyArrayPassed_ArrayRemainsUnchanged()
        {
            int[] input = new int[] { };
            ReverseArray.Reverse(input);
            int[] correct = new int[] { };
            CollectionAssert.AreEqual(correct, input);
        }
    }
}
