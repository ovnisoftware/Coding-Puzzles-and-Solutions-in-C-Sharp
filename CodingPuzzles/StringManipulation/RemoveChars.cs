using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Remove all characters from a string except for these characters: [ { } ( ) ] without using Regex.
    //Regex way:
    //x = Regex.Replace(x, "[^{}\\][()]", "");
    public static class RemoveChars
    {
        public static string Remove(string x)
        {
            string result = "";
            char[] arr = new char[] { '[', '{', '(', ')', '}', ']' };
            foreach (char c in arr)
            {
                if (arr.Contains(c))
                    result += c.ToString();
            }
            return result;
        }
        //string x = "(test)[1234]{testagain!}";
        //Console.WriteLine(RemoveChars.Remove(x)); 
    }
}
