using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a method to check if a string is a palindrome (spelled the same forward and backward excluding whitespace)
    //Ex. Anna
    //Ex. Never odd or even
    public static class Is_Palindrome
    {
        public static bool IsPalindrome(string x)
        {
            //Converts string to all lower case
            x = x.ToLower();

            //Removes all whitespace from string
            x = x.Replace(" ", "");

            //Compares first to last character in string, moving inward with each iteration
            for (int i = 0; i < x.Length - 1 - i; i++)
            {
                if (x[i].ToString() != x[x.Length - 1 - i].ToString())
                    return false;
            }
            return true;
        }
        ////Call this in Program.cs to test
        //Console.WriteLine(Is_Palindrome.IsPalindrome("Never odd or even"));
        ////Output should be True
    }
}