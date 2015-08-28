using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //Stack

namespace CodingPuzzles
{
    public static class Stack_Max
    {
        //Write a function to determine the maximum of a stack
        public static int MaxStack(Stack s)
        {
            //throw exception if an empty stack is passed
            if (s.Count == 0)
                throw new Exception();

            //Create a copy of the stack so the original remains intact
            Stack temp = new Stack(new Stack(s));
            int result = (int)temp.Pop();

            //Iterate through the copied stack comparing the popped elements with the max
            while (temp.Count != 0)
            {
                int i = (int)temp.Pop();
                if (i > result)
                    result = i;
            }
            return result;
        }
        ////Output should be 202
        //Stack s = new Stack(new [] { 1, 32, 3, 4, 202, 29 });
        //Console.WriteLine(Stack_Max.MaxStack(s));
    }
}
