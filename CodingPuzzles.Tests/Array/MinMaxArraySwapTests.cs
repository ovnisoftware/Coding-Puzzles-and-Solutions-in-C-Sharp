using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class MinMaxArraySwapTests
    {
        [TestMethod]
        public void MinMaxSwap_123ArrayPassed_Returns321Array()
        {
            int[] input = new int[] { 1, 2, 3 };
            MinMaxArraySwap.MinMaxSwap(input);
            int[] correct = new int[] { 3, 2, 1 };
            CollectionAssert.AreEqual(correct, input);
        }
        [TestMethod]
        public void MinMaxSwap_111ArrayPassed_Returns111Array()
        {
            int[] input = new int[] { 1, 1, 1 };
            MinMaxArraySwap.MinMaxSwap(input);
            int[] correct = new int[] { 1, 1, 1 };
            CollectionAssert.AreEqual(correct, input);
        }
        [TestMethod]
        public void MinMaxSwap2_123ArrayPassed_Returns321Array()
        {
            int[] input = new int[] { 1, 2, 3 };
            MinMaxArraySwap.MinMaxSwap2(input);
            int[] correct = new int[] { 3, 2, 1 };
            CollectionAssert.AreEqual(correct, input);
        }
        [TestMethod]
        public void MinMaxSwap2_111ArrayPassed_Returns111Array()
        {
            int[] input = new int[] { 1, 1, 1 };
            MinMaxArraySwap.MinMaxSwap2(input);
            int[] correct = new int[] { 1, 1, 1 };
            CollectionAssert.AreEqual(correct, input);
        }
    }
}
