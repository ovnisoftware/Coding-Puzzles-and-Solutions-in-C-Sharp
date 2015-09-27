using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //How would you design a stack which, in addition to push and pop, also has a function min which returns the minimum element? Push, pop and min should all operate in O(1) time
    //This solution has a GetMin method that operates in O(1) time complexity.  It does this by maintaining two stacks.  One stack simply stores everything that is pushed and popped onto it.  The second stack only contains minimum values and is the same size as the first stack.
    //Good explanation: http://stackoverflow.com/questions/685060/design-a-stack-such-that-getminimum-should-be-o1
    //Source: Cracking the Coding Interview 5th Edition p. 80
    public class MinStack
    {
        private Stack<int> listOfMins;
        private StackNode head;

        public MinStack()
        {
            head = null;
            listOfMins = new Stack<int>();
        }

        public void Push(int x)
        {
            StackNode n = new StackNode(x);
            if (head == null)
            {
                head = n;
                listOfMins.Push(n.Data);
            }
            else
            {
                if (head.Data <= listOfMins.Peek())
                    listOfMins.Push(head.Data);
                else
                    listOfMins.Push(listOfMins.Peek());
                n.Next = head;
                head = n;
            }
        }

        public int Pop()
        {
            if (head == null)
                throw new Exception("Empty Stack");
            listOfMins.Pop();
            int result = head.Data;
            head = head.Next;
            return result;
        }

        public int GetMin()
        {
            if (head == null)
                throw new Exception("Empty Stack");
            return listOfMins.Peek();
        }
        //MinStack s = new MinStack();
        //s.Push(1);
        //s.Push(2);
        //s.Push(-5);
        //s.Push(-10);
        //Console.WriteLine(s.GetMin());
        //Console.WriteLine(s.Pop());
        //Console.WriteLine(s.GetMin());
        //Console.WriteLine(s.Pop());
        //Console.WriteLine(s.GetMin());
        //Console.WriteLine(s.Pop());
        //Console.WriteLine(s.GetMin());
        //Console.WriteLine(s.Pop());
    }
}