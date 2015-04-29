using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class Factorial_Recursive
    {
        //Write a recursive method that returns the factorial of a given integer
        //0! = 1
        //1! = 1
        //Good explanation of recursive factorial in C++: https://www.youtube.com/watch?v=_OmRGjbyzno
        //Thanks myCodeSchool channel on Youtube!
        public static int Factorial(int x)
        {
            //Base case
            if (x == 0)
                return 1;
            else
                return (x * Factorial(x - 1));
        }
        ////Call this in Program.cs to test
        //Console.WriteLine(Factorial_Recursive.Factorial(6));
        ////Output should be 720
    }
}