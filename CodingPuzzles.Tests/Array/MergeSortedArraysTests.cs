using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class MergeSortedArraysTests
    {
        [TestMethod]
        public void MergeArrays_PassTwoSortedArrays_ReturnsSortedArray()
        {
            int[] x = new int[] { 1, 3, 5, 0, 0, 0, 0 };
            int[] y = new int[] { 2, 4, 6, 7 };
            int[] result = MergeSortedArrays.MergeArrays(x, y, 2);
            int[] correct = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            CollectionAssert.AreEqual(correct, result);
        }
        [TestMethod]
        public void MergeArrays_PassTwoEmptyArray_ReturnsSortedArray()
        {
            int[] x = new int[] { 1, 3, 5 };
            int[] y = new int[] { };
            int[] result = MergeSortedArrays.MergeArrays(x, y, 2);
            int[] correct = new int[] { 1, 3, 5 };
            CollectionAssert.AreEqual(correct, result);
        }
    }
}
