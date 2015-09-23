using System;
using System.Collections; //Necessary for Stack class
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Create a queue with two stacks
    //A stack is LIFO (Last in, First out)
    //A queue is FIFO (First in, First out)
    //This implementation works but is inefficient because the stacks are emptied and restacked on every Dequeue call
    public class TwoStackQueue
    {
        //Stack1 will contain all the elements
        private Stack<string> stack1 = new Stack<string>();

        //Stack2 will act as a temporary container of elements when an element needs to be dequeued
        private Stack<string> stack2 = new Stack<string>();

        public void Enqueue(string queueThis)
        {
            stack1.Push(queueThis);
        }

        public string Dequeue()
        {
            if (stack1.Count == 0)
                throw new Exception("Empty Queue");

            while (stack1.Count != 0)
                stack2.Push(stack1.Pop());

            string result = stack2.Pop();

            //Handles case where stack1 only contained one element
            if (stack2.Count == 0)
                return result;

            while (stack2.Count != 0)
                stack1.Push(stack2.Pop());

            return result;
        }
        ////Copy this to Program.cs to test
        //TwoStackQueue q = new TwoStackQueue();
        //q.Enqueue("Element 1");
        //q.Enqueue("Element 2");
        //q.Enqueue("Element 3");
        //Console.WriteLine(q.Dequeue());
        //Console.WriteLine(q.Dequeue());
        //Console.WriteLine(q.Dequeue());
    }

    //More efficient implementation which only shifts elements from new stack to old stack when the old stack is empty
    //Source: Cracking Coding Interview Fifth Edition p. 81
    public class Two_Stack_Queue2
    {
        Stack<string> stackNew = new Stack<string>();
        Stack<string> stackOld = new Stack<string>();

        public void Enqueue(string queueThis)
        {
            stackNew.Push(queueThis);
        }

        public string Dequeue()
        {
            shiftStacks();
            if (stackOld.Count == 0)
                throw new Exception("Empty Queue");
            return stackOld.Pop();
        }

        //Only copies elements from new stack to old stack when the old stack is empty
        private void shiftStacks()
        {
            if (stackOld.Count == 0)
                while (stackNew.Count != 0)
                    stackOld.Push(stackNew.Pop());
        }
        ////Copy this to Program.cs to test
        //Two_Stack_Queue2 q = new Two_Stack_Queue2();
        //q.Enqueue("Element 1");
        //q.Enqueue("Element 2");
        //q.Enqueue("Element 3");
        //Console.WriteLine(q.Dequeue());
        //Console.WriteLine(q.Dequeue());
        //q.Enqueue("Element 4");
        //Console.WriteLine(q.Dequeue());
        //Console.WriteLine(q.Dequeue());
    }
}