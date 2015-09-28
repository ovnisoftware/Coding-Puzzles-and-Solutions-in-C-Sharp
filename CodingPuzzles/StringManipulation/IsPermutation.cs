using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class IsPermutation
    {
        //Given two strings, write a method to decide if one is a permutation of the other.
        //dog is a permutation of god, algorithm is case sensitive and white space counts
        //Cracking the Coding Interview, 5th Edition p. 73
        public static bool PermutationCheck(string x, string y)
        {
            if (x.Length != y.Length)
                return false;

            char[] xArr = x.ToCharArray();
            char[] yArr = y.ToCharArray();

            //Sort both char arrays
            Array.Sort(xArr);
            Array.Sort(yArr);

            //Check if the arrays are in the same order
            return (xArr.SequenceEqual(yArr));
        }
        //Console.WriteLine(IsPermutation.PermutationCheck("cat","tac"));
    }
}
