﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Reverse a string using a stack
    //Source: https://www.youtube.com/watch?v=hNP72JdOIgY Solution in C++
    public static class Reverse_String_With_Stack
    {
        public static string ReverseString(string input)
        {
            string output = "";

            //Declare a stack of type character to store the characters from the input string
            Stack<char> stack = new Stack<char>();

            //Extract each character starting at the beginning from the input string
            //Push each char onto the stack
            foreach (char c in input)
                stack.Push(c);

            //Remove each char from the stack and append each one to the output string
            foreach (char c in stack)
                output += c;

            return output;
        }
        ////Call this in Program.cs to test
        //Console.WriteLine(Reverse_String_With_Stack.ReverseString("abcde"));
        ////Output should be "edcba"
    }
}