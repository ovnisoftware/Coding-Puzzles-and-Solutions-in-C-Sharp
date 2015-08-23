using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a program that takes a string and outpurs that same string with only one space between each word
    class Single_Space
    {
        public static string replaceSpace(string x)
        {
            x = x.Trim();
            while (x.Contains("  "))
                x = x.Replace("  ", " ");
            return x;
        }
    }
}