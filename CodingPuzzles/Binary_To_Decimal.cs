﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class Binary_To_Decimal
    {
        //Convert a binary string to an integer without using the Convert.ToInt32 class
        public static int BinaryToDecimal(string s)
        {
            int OnOff = 0;
            int result = 0;

            //Loop through each character in the passed string
            for (int i = 0; i < s.Length; i++)
            {
                //Parse each char of the passed string
                OnOff = Int32.Parse(s[i].ToString());
                //If the char is a 1, add 2^(the position it's in) to the result
                if (OnOff == 1)
                    result += (int)Math.Pow(2, s.Length - 1 - i);
            }
            return result;
        }
        ////Call in Program.cs to test
        //Console.WriteLine(Binary_To_Decimal.BinaryToDecimal("10111101")); 
        ////Output should be 189
    }
}
