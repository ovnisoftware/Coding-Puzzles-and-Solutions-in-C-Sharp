using System;
using System.Collections; //Stack
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class ReverseWords
    {
        //Reverse words in a string
        public static string Reverse(string s)
        {
            string result = "";
            Stack temp = new Stack();
            s = s.Trim();

            //Remove extra white space between characters
            while (s.Contains("  "))
                s = s.Replace("  ", " ");

            //Store each word on the Stack
            foreach (string x in s.Split(' '))
                temp.Push(x);

            //Add each word to the result string in reverse order since a stack is a FIFO data structure
            while (temp.Count != 0)
                result += temp.Pop() + " ";

            return result.Trim();
        }
        //string x = "   a  b   c   d    e   f   g  hij   k   l  m   no   p  ";
        //Console.WriteLine(ReverseWords.Reverse(x));
    }
}
