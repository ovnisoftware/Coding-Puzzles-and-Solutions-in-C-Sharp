using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a function to calculate the factorial of a given integer
    public static class Factorial
    {
        public static int FactorialCalculation(int a)
        {
            //Verifies that integer passed is positive integer at least 1
            if (a >= 1)
            {
                int iterations = a;
                int result = a;
                for (int i = 1; i < iterations; i++)
                {
                    result = result * (a - 1);
                    a--;
                }
                return result;
            }
            else
                return -100;
        }
        ////Call this in Program.cs to test
        //Console.WriteLine(Factorial.FactorialCalculation(6));
        ////Should return 720
    }
}