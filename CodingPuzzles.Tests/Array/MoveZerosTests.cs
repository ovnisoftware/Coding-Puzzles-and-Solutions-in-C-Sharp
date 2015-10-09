using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class MoveZerosTests
    {
        [TestMethod]
        public void Move_ArrayWithNumbers2Zeros_ZerosAtEnd()
        {
            int[] input = new int[] { 0, 1, 0, 3, 12 };
            MoveZeros.Move(input);
            int[] correct = new int[] { 1, 3, 12, 0, 0 };
            CollectionAssert.AreEqual(correct, input);
        }
        [TestMethod]
        public void Move_ArrayWithNoZeros_ArrayIsUnchanged()
        {
            int[] input = new int[] { 4, 3, 2, 1 };
            MoveZeros.Move(input);
            int[] correct = new int[] { 4, 3, 2, 1 };
            CollectionAssert.AreEqual(correct, input);
        }
        [TestMethod]
        public void Move_ArrayWithAllZeros_ArrayIsUnchanged()
        {
            int[] input = new int[] { 0, 0, 0, 0 };
            MoveZeros.Move(input);
            int[] correct = new int[] { 0, 0, 0, 0 };
            CollectionAssert.AreEqual(correct, input);
        }
    }
}
