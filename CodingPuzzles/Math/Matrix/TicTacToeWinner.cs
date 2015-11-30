using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a function to determine if a TicTacToe board (3x3 board implemented as a 2D array) has a winner
    public class TicTacToeWinner
    {
        public static bool IsWinner(int[,] x)
        {
            bool result = false;
            for (int i = 0; i < x.GetUpperBound(0); i++)
            {
                for (int k = 0; k < x.GetUpperBound(0); k++)
                {
                    if ((x[i, k] != 0) && (x[i, k] != 1))
                        throw new Exception("Invalid board, values must be only 1 or 0");
                }
            }


            //Checks for 3 x's straight across (3 cases)
            for (int i = 0; i < x.GetUpperBound(0); i++)
            {
                if (result)
                    return result;

                result = true;
                for (int k = 0; k < x.GetUpperBound(0); k++)
                {
                    if (x[i, k] == 0)
                        result = false;
                }
            }

            //Checks for 3 x's straight down (3 cases)
            for (int i = 0; i < x.GetUpperBound(0); i++)
            {
                if (result)
                    return result;

                result = true;
                for (int k = 0; k < x.GetUpperBound(0); k++)
                {
                    if (x[k, i] == 0)
                        result = false;
                }
            }

            //Checks for diagonal case #1
            result = true;
            for (int i = 0; i < x.GetUpperBound(0); i++)
            {
                if (x[i, i] == 0)
                    result = false;
            }
            if (result)
                return result;

            //Checks for diagonal case #2
            result = true;
            for (int i = 0; i < x.GetUpperBound(0); i++)
            {
                if (x[i, x.GetUpperBound(0) - i] == 0)
                    result = false;
            }
            if (result)
                return result;
            return result;
        }
    }
}