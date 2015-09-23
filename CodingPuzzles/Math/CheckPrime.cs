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

            //Start loop at 2 since we don't need to check the 1 case (since all numbers are divisible by 1)
            //loop (i < x) times instead of (i <= x) times because (x % x) will return zero
            for (int i = 2; i < x; i++)
            {
                if ((x % i) == 0)
                    return false;
            }
            return true;
        }
    }
}