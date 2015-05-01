using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a program that prints the Fibonacci Sequence using iteration
    //1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144...
    //Prev + current = fib
    //0 + 1 = 1
    //1 + 1 = 2
    //2 + 1 = 3
    //2 + 3 = 5
    //5 + 3 = 8
    public static class FibonacciSequence
    {
        public static int Fibonacci(int x)
        {
            int prev = 0;
            int current = 1;
            int fib = 1;
            for (int i = 0; i < x - 1; i++)
            {
                fib = prev + current;
                prev = current;
                current = fib;
            }
            return fib;
        }
        ////Call this in Program.cs to test
        //Console.WriteLine(FibonacciSequence.Fibonacci(7));
        ////Output should be 13
    }
}