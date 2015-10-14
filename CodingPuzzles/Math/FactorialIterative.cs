using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a function to calculate the factorial of a given integer iteratively
    //0! = 1
    public static class Factorial
    {
        public static int GetFactorial(int x)
        {
            if (x < 0)
                throw new Exception("Input must be at least 0");

            int result = 1;

            for (int i = 1; i <= x; i++)
                result = result * i;

            return result;
        }
    }
}