using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class AddBinary
    {
        public static string Sum(string x, string y)
        {
            //convert x to int
            int num1 = Convert.ToInt32(x, 2);

            //convert y to int
            int num2 = Convert.ToInt32(y, 2);

            //add them
            int result = num1 + num2;

            //convert result to binary
            return Convert.ToString(result, 2);
        }

        public static string Sum2(string x, string y)
        {
            //convert x to int
            int xVal = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == '1')
                    xVal += (int)Math.Pow(2, x.Length - 1 - i);
            }

            //convert y to int
            int yVal = 0;
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] == '1')
                    yVal += (int)Math.Pow(2, x.Length - 1 - i);
            }

            int result = xVal + yVal;

            //Convert result to binary
            string resultBinary = "";
            while (result > 0)
            {
                int remainder = result % 2;
                result = result >> 1;
                resultBinary = remainder.ToString() + resultBinary;
            }
            return resultBinary;
        }
    }
}
