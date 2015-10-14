using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a recursive method that returns the factorial of a given integer
    //0! = 1
    //1! = 1
    //Good explanation of recursive factorial in C++: https://www.youtube.com/watch?v=_OmRGjbyzno
    //Thanks myCodeSchool channel on Youtube!
    public static class FactorialRecursive
    {
        public static int GetFactorial(int x)
        {
            if (x < 0)
                throw new Exception("Input must be at least 0");
            //Base case
            if (x == 0)
                return 1;
            else
                return (x * GetFactorial(x - 1));
        }
    }
}