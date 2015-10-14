using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a function to find the longest common prefix string amongst an array of strings. 
    //Example: ['flower', 'flow', 'fellow', 'fleet']
    //Answer: f
    //Source: https://leetcode.com/problems/longest-common-prefix/
    public static class LongestCommonPrefix
    {
        //Compares each character of each string starting at first until it finds a mismatch
        public static string FindPrefix(string[] x)
        {
            string prefix = "";
            for (int i = 0; i < x.Length; i++)
            {
                prefix = x[i].Substring(0, i + 1);
                for (int k = 1; k < x.Length; k++)
                {
                    string subString = x[k].Substring(0, i + 1);
                    if (prefix != subString)
                        return prefix.Remove(prefix.Length - 1);
                }
            }
            return prefix;
        }

        //Sort array alphabetically and compare first and last string
        public static string FindPrefix1(string[] input)
        {
            Array.Sort(input);
            string first = input[0];
            string last = input[input.Length - 1];
            string prefix = "";

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == last[i])
                    prefix += first[i];
            }
            return prefix;
        }
        //string[] x = new string[] { "flower", "flow", "fello", "fleet" };
        //Console.WriteLine(LongestCommonPrefix.FindPrefix1(x)); 
    }
}