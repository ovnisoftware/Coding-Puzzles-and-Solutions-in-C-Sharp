using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math
{
    [TestClass]
    public class ClimbingStairsTests
    {
        [TestMethod]
        public void CombosRecursive_NegativeIntPassed_Returns0()
        {
            Assert.AreEqual(0, ClimbingStairs.CombosRecursive(-10));
        }
        [TestMethod]
        public void CombosRecursive_5Passed_Returns13()
        {
            Assert.AreEqual(13, ClimbingStairs.CombosRecursive(5));
        }
        [TestMethod]
        public void CombosRecursive_37Passed_IntOverflows()
        {
            Exception exception = null;
            try
            {
                ClimbingStairs.CombosRecursive(37);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void CombosIterative_NegativeIntPassed_Returns0()
        {
            Assert.AreEqual(0, ClimbingStairs.CombosIterative(-10));
        }
        [TestMethod]
        public void CombosIterative_5Passed_Returns13()
        {
            Assert.AreEqual(13, ClimbingStairs.CombosIterative(5));
        }
        [TestMethod]
        public void CombosIterative_37Passed_IntOverflows()
        {

            Exception exception = null;
            try
            {
                ClimbingStairs.CombosIterative(37);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }

    }
}
