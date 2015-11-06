using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace CodingPuzzles.Tests.StackTests
{
    [TestClass]
    public class StackMaxTests
    {
        [TestMethod]
        public void GetMax_PassStack202Max_Returns202()
        {
            Stack s = new Stack(new[] { 1, 32, 3, 4, 202, 29 });
            Assert.AreEqual(202, StackMax.GetMax(s));
        }
        [TestMethod]
        public void GetMax_PassOneElement_Returns1()
        {
            Stack s = new Stack(new[] { 1 });
            Assert.AreEqual(1, StackMax.GetMax(s));
        }
        [TestMethod]
        public void GetMax_PassEmptyStack_ThrowsException()
        {
            Exception exception = null;
            try
            {
                Stack s = new Stack();
                Assert.AreEqual(1, StackMax.GetMax(s));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
