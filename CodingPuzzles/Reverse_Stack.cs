using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  //Necessary for Stack

namespace CodingPuzzles
{
    //Reverse a stack
    public static class Reverse_Stack
    {
        //This method returns a stack
        public static Stack Reverse(Stack input)
        {
            //Declare another stack to store the values from the passed stack
            Stack temp = new Stack();

            //While the passed stack isn't empty, pop elements from the passed stack onto the temp stack
            while (input.Count != 0)
                temp.Push(input.Pop());

            return temp;
        }

        //This method reverses the stack it is passed and returns void
        public static void Reverse2(Stack input)
        {
            ArrayList a = new ArrayList();

            while (input.Count != 0)
                a.Add(input.Pop());

            int length = a.Count - 1;

            for (int i = length; i >= 0; i--)
                input.Push(a[i]);
        }
    }
}