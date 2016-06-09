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
        public static bool IsWinner(int[,] board)
        {
            //bool result = false;
            //Check that board only contains 1's and 0's
            for (int i = 0; i < board.GetUpperBound(0); i++)
            {
                for (int k = 0; k < board.GetUpperBound(0); k++)
                {
                    if ((board[i, k] != 0) && (board[i, k] != 1))
                        throw new Exception("Invalid board, values must be only 1 or 0");
                }
            }

            int count = 0;
            //Check rows
            for (int i = 0; i < board.GetLength(0); i++)
            {
                count = 0;
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    if (board[i, k] == 1)
                    {
                        count++;
                        if (count == 3)
                            return true;
                    }
                }
            }

            //Check columns
            for (int i = 0; i < board.GetLength(0); i++)
            {
                count = 0;
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    if (board[k, i] == 1)
                    {
                        count++;
                        if (count == 3)
                            return true;
                    }
                }
            }

            //Check first diagonal
            count = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, i] == 1)
                {
                    count++;
                    if (count == 3)
                        return true;
                }
            }

            //check second diagonal
            count = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, board.GetLength(0) - i - 1] == 1)
                {
                    count++;
                    if (count == 3)
                        return true;
                }
            }
            return false;
        }
    }
}