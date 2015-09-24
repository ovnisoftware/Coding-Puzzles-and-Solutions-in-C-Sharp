using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Convert Hexadecimal (0-9, A-F) to Binary with and without using Convert class
    //Source: http://stackoverflow.com/questions/6617284/c-sharp-how-convert-large-hex-string-to-binary
    public static class HexToBinary
    {
        //Stores binary values of hexadecimal characters
        private static readonly Dictionary<char, string> HexCharToBinary = new Dictionary<char, string>
        {
            { '0', "0000" },
            { '1', "0001" },
            { '2', "0010" },
            { '3', "0011" },
            { '4', "0100" },
            { '5', "0101" },
            { '6', "0110" },
            { '7', "0111" },
            { '8', "1000" },
            { '9', "1001" },
            { 'a', "1010" },
            { 'b', "1011" },
            { 'c', "1100" },
            { 'd', "1101" },
            { 'e', "1110" },
            { 'f', "1111" }
           };

        //Conversion without Convert class
        public static string ConvertIt(string s)
        {
            StringBuilder result = new StringBuilder();
            s = s.ToLower();

            foreach (char c in s)
                result.Append(HexCharToBinary[c] + " ");

            return result.ToString();
        }

        //Conversion using Convert class
        public static string ConvertIt1(string s)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in s)
                result.Append(Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0') + " ");

            return result.ToString();
        }
        ////Run in Program.cs to test
        //Console.WriteLine(HexToBinary.ConvertIt("01F"));
        //Console.WriteLine(HexToBinary.ConvertIt2("01F"));
        ////Output for both should be 0000 0001 1111
    }
}