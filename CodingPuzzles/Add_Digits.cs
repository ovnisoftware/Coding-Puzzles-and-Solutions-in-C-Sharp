using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.
    //For example:
    //Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.
    //Source: https://leetcode.com/problemset/algorithms/
    public static class Add_Digits
    {
        public static int AddDigits(int x)
        {
            while (true)
            {
                int result = 0;
                List<int> listOfInts = new List<int>();

                //Add each digit in the passed integer into an array 
                while (x > 0)
                {
                    listOfInts.Add(x % 10);
                    x = x / 10;
                }
                
                //Add up all digits in the array
                foreach (int i in listOfInts)
                    result += i;

                if (result.ToString().Length == 1)
                    return result;
                else
                    x = result;
            }
        }
        //Console.WriteLine(Add_Digits.AddDigits(38989));
    }
}