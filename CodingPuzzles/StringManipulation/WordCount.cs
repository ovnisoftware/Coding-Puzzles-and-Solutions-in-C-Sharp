using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Count the number of words in a string (Needs to handle multiple spaces between words)
    public static class WordCount
    {
        public static int Count(string x)
        {
            int result = 0;

            //Trim whitespace from beginning and end of string
            x = x.Trim();

            //Ensure there is only one space between each word in the passed string
            while (x.Contains("  "))
                x = x.Replace("  ", " ");

            //Count the words
            foreach (string y in x.Split(' '))
                result++;

            return result;
        }
        ////Call this in Program.cs to test
        //string x = "   a  b   c   d    e   f   g  hij   k   l  m   no   p  ";
        //Console.WriteLine(WordCount.Count(x));
        ////Output should be 13
    }
}