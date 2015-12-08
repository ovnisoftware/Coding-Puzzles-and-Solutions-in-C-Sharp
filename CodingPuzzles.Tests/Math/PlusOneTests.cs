using System;
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
        [TestMethod]
        public void AddOne_Passnull_ThrowsException()
        {
            Exception exception = null;
            try
            {
                PlusOne.AddOne(null);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void AddOne_PassNothing_ThrowsException()
        {
            Exception exception = null;
            try
            {
                PlusOne.AddOne();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }

        //AddOne1 tests
        [TestMethod]
        public void AddOne1_Pass123_Returns124()
        {
            Assert.AreEqual(124, PlusOne.AddOne1(1, 2, 3));
        }
        [TestMethod]
        public void AddOne1_Pass1_Returns2()
        {
            Assert.AreEqual(2, PlusOne.AddOne1(1));
        }
        [TestMethod]
        public void AddOne1_Pass999_Returns1000()
        {
            Assert.AreEqual(1000, PlusOne.AddOne1(9, 9, 9));
        }
        [TestMethod]
        public void AddOne1_Passnull_ThrowsException()
        {
            Exception exception = null;
            try
            {
                PlusOne.AddOne1(null);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void AddOne1_PassNothing_ThrowsException()
        {
            Exception exception = null;
            try
            {
                PlusOne.AddOne1();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
