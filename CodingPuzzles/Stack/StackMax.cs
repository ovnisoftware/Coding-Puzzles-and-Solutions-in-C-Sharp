using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //Stack

namespace CodingPuzzles
{
    public static class StackMax
    {
        //Write a function to determine the maximum of a stack
        public static int GetMax(Stack s)
        {
            //throw exception if an empty stack is passed
            if ((s.Count == 0) || (s == null))
                throw new Exception("Empty Stack");

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
    }
}
