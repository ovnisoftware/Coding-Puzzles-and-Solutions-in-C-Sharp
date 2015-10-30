using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace CodingPuzzles.Tests.StackTests
{
    [TestClass]
    public class ReverseStackTests
    {
        [TestMethod]
        public void Reverse_Passed123Stack_Returns321Stack()
        {
            Stack input = new Stack();
            input.Push(1);
            input.Push(2);
            input.Push(3);
            Stack output = ReverseStack.Reverse(input);
            Stack correct = new Stack();
            correct.Push(3);
            correct.Push(2);
            correct.Push(1);
            CollectionAssert.AreEqual(correct, output);
        }
        [TestMethod]
        public void Reverse_PassedEmptyStack_ReturnsEmptyStack()
        {
            Stack input = new Stack();
            Stack output = ReverseStack.Reverse(input);
            Stack correct = new Stack();
            CollectionAssert.AreEqual(correct, output);
        }
    }
}
