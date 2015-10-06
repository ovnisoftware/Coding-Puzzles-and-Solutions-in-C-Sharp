using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Given a non-negative number represented as an array of digits, plus one to the number.
    //Source: https://leetcode.com/problems/plus-one/
    public static class PlusOne
    {
        //Multiplying each digit in array by 10^x, summing them and adding 1 
        public static int AddOne(params int[] x)
        {
            int result = 0;
            for (int i = 0; i < x.Length; i++)
            {
                int multiplier = (int)Math.Pow(10, x.Length - 1 - i);
                result += x[i] * multiplier;
            }
            return result + 1;
        }

        //String conversion technique
        public static int AddOne1(params int[] input)
        {
            string strAnswer = "";
            for (int i = 0; i < input.Length; i++)
                strAnswer += input[i];
            int result = Convert.ToInt32(strAnswer);
            return ++result;
        }

        //Console.WriteLine(PlusOne.AddOne(9,9,9));
        //Console.WriteLine(PlusOne.AddOne1(9,9,9));
    }
}
