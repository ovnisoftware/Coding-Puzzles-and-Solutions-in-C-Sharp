using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles.StringManipulation
{
    public static class IsAnagram
    {
        //Given two strings s and t, write a function to determine if t is an anagram of s.
        //You may assume the string contains only lowercase alphabets.
        //Ex. listen and silent are anagrams
        //Source: https://leetcode.com/problems/valid-anagram/

        //Compare 2 sorted char arrays, could alternatively use 2 dictionaries
        public static bool IsItAnagram(string x, string y)
        {
            char[] xArray = x.ToCharArray();
            Array.Sort(xArray);
            
            char[] yArray = y.ToCharArray();
            Array.Sort(yArray);

            return (xArray.SequenceEqual(yArray));
        }
        //Console.WriteLine(IsAnagram.IsItAnagram("listen", "silent"));
    }
}