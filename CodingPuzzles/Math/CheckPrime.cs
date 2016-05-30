using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public class CheckPrime
    {
        //Write a method that determines if a given number is prime (Divisible by only 1 and itself)
        //Primes: 2,3,5,7,11,13...

        //Simple, but not very efficient solution
        public static bool IsPrime(int x)
        {
            //There are no primes less than 2 (2 is the first prime number)
            if (x < 2)
                return false;

            //Even number test
            if ((x % 2 == 0) && (x != 2))
                return false;

            //Only check odd numbers
            for (int i = 3; i < x; i += 2)
            {
                if (x % i == 0)
                    return false;
            }

            return true;
        }
    }
}