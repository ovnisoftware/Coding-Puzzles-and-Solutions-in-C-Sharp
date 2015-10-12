using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class SortDescTests
    {
        [TestMethod]
        public void Sort_UnsortedArrayPassed_ReturnsSortedArray()
        {
            int[] input = new int[] { 7, 3, 2, 4, 5, 1, 8, 6 };
            int[] correct = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };
            SortDesc.Sort(input);
            CollectionAssert.AreEqual(correct, input);
        }
        [TestMethod]
        public void Sort_EmptyArrayPassed_ArrayRemainsEmpty()
        {
            int[] input = new int[] { };
            int[] correct = new int[] { };
            SortDesc.Sort(input);
            CollectionAssert.AreEqual(correct, input);
        }
    }
}