using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a method to replace all spaces in a string with '%20'
    public static class Replace_Space
    {
        public static string ReplaceSpace(string s)
        {
            s = s.Trim();
            s = s.Replace(" ", "%20");
            return s;
        }
    }
}