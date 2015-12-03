﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math
{
    [TestClass]
    public class PlusOneTests
    {
        [TestMethod]
        public void AddOne_Pass123_Returns124()
        {
            Assert.AreEqual(124, PlusOne.AddOne(1, 2, 3));
        }
        [TestMethod]
        public void AddOne_Pass1_Returns2()
        {
            Assert.AreEqual(2, PlusOne.AddOne(1));
        }
        [TestMethod]
        public void AddOne_Pass999_Returns1000()
        {
            Assert.AreEqual(1000, PlusOne.AddOne(9,9,9));
        }
    }
}