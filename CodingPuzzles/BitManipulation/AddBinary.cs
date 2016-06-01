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
    }
}
