using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Break A-Z code
    //Source: http://www.mycodeschool.com/problems/secret-code
    public static class BreakAZCode
    {
        public static string Encode(string input)
        {
            string encoded = "";
            input = input.ToLower();
            foreach (char c in input)
            {
                foreach (KeyValuePair<string, char> letter in codes)
                {
                    if (letter.Value == c)
                        encoded += letter.Key;
                }
            }
            return encoded;
        }

        public static string Decode(string input)
        {
            string decoded = "";

            //Break string into 2 digit pieces
            List<string> TwoDigits = new List<string>();
            int index = 0;
            while (index < input.Length)
            {
                TwoDigits.Add(input.Substring(index, 2));
                index += 2;
            }

            foreach (string s in TwoDigits)
            {
                foreach (KeyValuePair<string, char> letter in codes)
                {
                    if (letter.Key == s)
                        decoded += letter.Value;
                }
            }
            return decoded;
        }

        private static readonly Dictionary<string, char> codes = new Dictionary<string, char>()
        {
            { "01", 'a' },
            { "02", 'b' },
            { "03", 'c' },
            { "04", 'd' },
            { "05", 'e' },
            { "06", 'f' },
            { "07", 'g' },
            { "08", 'h' },
            { "09", 'i' },
            { "10", 'j' },
            { "11", 'k' },
            { "12", 'l' },
            { "13", 'm' },
            { "14", 'n' },
            { "15", 'o' },
            { "16", 'p' },
            { "17", 'q' },
            { "18", 'r' },
            { "19", 's' },
            { "20", 't' },
            { "21", 'u' },
            { "22", 'v' },
            { "23", 'w' },
            { "24", 'x' },
            { "25", 'y' },
            { "26", 'z' }
        };
    }
    //string s = "test";
    //Console.WriteLine("Original: " + s);
    //s = BreakCode.Encode(s);
    //Console.WriteLine("Encoded: " + s);
    //s = BreakCode.Decode(s);
    //Console.WriteLine("Decoded: " + s);
}