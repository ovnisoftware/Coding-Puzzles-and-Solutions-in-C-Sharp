﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a program that prints the Fibonacci Sequence
    //1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144...
    //Base case F1 = 1, F2 = 1
    //F(n) = f(n-1) + f (n-2)
    //Returns nth fibonacci number passed 
    public static class FibonacciRecursive
    {
        public static int GetFibonacci(int x)
        {
            if (x < 1)
                throw new Exception("Input must be at least 1");
            if ((x == 1) || (x == 2))
                return 1;
            else
                return (GetFibonacci(x - 1) + GetFibonacci(x - 2));
        }
    }
}