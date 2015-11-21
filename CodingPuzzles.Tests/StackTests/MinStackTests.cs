using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StackTests
{
    [TestClass]
    public class MinStackTests
    {
        [TestMethod]
        public void GetMin_NullStack_ThrowsException()
        {
            Exception exception = null;
            try
            {
                MinStack s = new MinStack();
                s.GetMin();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void GetMin_4isMin_Returns4()
        {
            MinStack s = new MinStack();
            s.Push(5);
            s.Push(4);
            s.Push(10);
            Assert.AreEqual(4, s.GetMin());
        }
        [TestMethod]
        public void GetMin_Negative10isMin_ReturnsNegative10()
        {
            MinStack s = new MinStack();
            s.Push(5);
            s.Push(4);
            s.Push(-10);
            s.Push(10);
            Assert.AreEqual(-10, s.GetMin());
        }
    }
}