using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Reverse Integer
    //Source: https://leetcode.com/problems/reverse-integer/
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            if (x == 0)
                return 0;

            bool IsNegative = false;
            if (x < 0)
            {
                IsNegative = true;
                x = x * -1;
            }

            string result = "";
            while (x > 0)
            {
                int digit = x % 10;
                result += digit;
                x = x / 10;
            }

            //Catches StackOverFlow Exception if x reversed is larger than 2,147,483,647 or less than –2,147,483,648
            try
            {
                if (IsNegative)
                    return (Convert.ToInt32(result) * -1);
                else
                    return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}