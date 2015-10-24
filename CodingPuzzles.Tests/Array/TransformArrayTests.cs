using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class TransformArrayTests
    {
        [TestMethod]
        public void Catalog_PassArray_ReturnsDictionary()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            Dictionary<int, int> result = TransformArray.Catalog(input);
            Dictionary<int, int> correct = new Dictionary<int, int>();
            correct.Add(1, 1);
            correct.Add(2, 1);
            correct.Add(3, 1);
            correct.Add(4, 1);
            correct.Add(5, 1);
            CollectionAssert.AreEqual(correct, result);
        }
        [TestMethod]
        public void Catalog_PassEmptyArray_ReturnsEmptyDictionary()
        {
            int[] input = new int[] { };
            Dictionary<int, int> result = TransformArray.Catalog(input);
            Dictionary<int, int> correct = new Dictionary<int, int>();
            CollectionAssert.AreEqual(correct, result);
        }
        [TestMethod]
        public void Catalog_PassArrayWithOneElement_ReturnsDictionary()
        {
            int[] input = new int[] { 1,1,1,1,};
            Dictionary<int, int> result = TransformArray.Catalog(input);
            Dictionary<int, int> correct = new Dictionary<int, int>();
            correct.Add(1, 4);
            CollectionAssert.AreEqual(correct, result);
        }
    }
}
