using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a program that prints the numbers from 1 to 100.
    //But for multiples of three print “Fizz” instead of the number
    //and for the multiples of five print “Buzz”.
    //For numbers which are multiples of both three and five print “FizzBuzz”.
    public static class FizzBuzz
    {
        public static string GetFizzBuzz()
        {
            string fbString = "";
            for (int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    fbString += "FizzBuzz" + Environment.NewLine;
                else if (i % 3 == 0)
                    fbString += "Fizz" + Environment.NewLine;
                else if (i % 5 == 0)
                    fbString += "Buzz" + Environment.NewLine;
                else
                    fbString += i.ToString() + Environment.NewLine;
            }
            return fbString;
        }
        ////Call this in Program.cs to test
        //Console.WriteLine(FizzBuzz.GetFizzBuzz());
    }
}
