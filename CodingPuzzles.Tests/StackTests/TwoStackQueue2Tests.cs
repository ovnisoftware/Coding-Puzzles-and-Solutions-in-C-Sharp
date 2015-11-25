using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StackTests
{
    [TestClass]
    public class TwoStackQueue2Tests
    {
        [TestMethod]
        public void Dequeue_EmptyStack_ThrowsException()
        {
            Exception exception = null;
            try
            {
                TwoStackQueue2 s = new TwoStackQueue2();
                s.Dequeue();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }

        [TestMethod]
        public void Dequeue_PassStackabc_Returnsa()
        {
            TwoStackQueue2 s = new TwoStackQueue2();
            s.Enqueue("a");
            s.Enqueue("b");
            s.Enqueue("c");

            Assert.AreEqual("a", s.Dequeue());
        }
        [TestMethod]
        public void Dequeue_PassStacka_Returnsa()
        {
            TwoStackQueue2 s = new TwoStackQueue2();
            s.Enqueue("a");

            Assert.AreEqual("a", s.Dequeue());
        }
    }
}
