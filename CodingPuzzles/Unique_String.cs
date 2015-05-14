using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Implement an algorithm to determine if a string has all unique characters.
    //What if you cannot use additional data structures?
    //Source: Cracking the Coding Interview p. 73

    //Uses a dictionary to store each character and checks for a duplicate entry
    public static class Unique_String
    {
        public static bool IsUnique(string s)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (d.ContainsKey(c))
                    return false;
                else
                    d.Add(c, 1);
            }
            return true;
        }
    }
}