using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Implement Conway's Game Of Life
    //Source: https://leetcode.com/problems/game-of-life/
    public static class GameOfLife
    {
        public static bool[,] Start(bool[,] oldBoard)
        {
            int numRows = oldBoard.GetLength(0); //number of rows
            int numCols = oldBoard.GetLength(1); //number of columns
            bool[,] newBoard = new bool[numRows, numCols];

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    //Get number of neighboring live cells (0 min, 8 max)
                    int numNeighbors = GetNumNeighbors(oldBoard, row, col);

                    //Check if cell is alive
                    if (oldBoard[row, col] == true)
                    {
                        //Any live cell with fewer than two live neighbors dies, as if caused by under-population.
                        if (numNeighbors < 2)
                        {
                            newBoard[row, col] = false;
                        }
                        //Any live cell with two or three live neighbors lives on to the next generation.
                        else if ((numNeighbors == 2) || (numNeighbors == 3))
                        {
                            newBoard[row, col] = true;
                        }
                        //Any live cell with more than three live neighbors dies, as if by over-population..
                        else if (numNeighbors > 3)
                        {
                            newBoard[row, col] = false;
                        }
                    }
                    //Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
                    else if (numNeighbors == 3)
                    {
                        newBoard[row, col] = true;
                    }
                }
            }
            return newBoard;
        }

        public static void DrawBoard(bool[,] board)
        {
            int numRows = board.GetLength(0); //number of rows
            int numCols = board.GetLength(1); //number of columns
            for (int row = 0; row < numRows; row++)
            {
                Console.WriteLine();
                for (int col = 0; col < numCols; col++)
                {
                    if (board[row, col] == true)
                        Console.Write(" * ");
                    else
                        Console.Write("   ");
                }
            }
        }

        //Get number of neighbors
        private static int GetNumNeighbors(bool[,] board, int row, int col)
        {
            int numRows = board.GetLength(0); //number of rows
            int numCols = board.GetLength(1); //number of columns
            int count = 0;

            //left neighbor
            if (row - 1 >= 0)
            {
                if (board[row - 1, col] == true)
                    count++;
            }
            //upper left neighbor
            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (board[row - 1, col - 1] == true)
                    count++;
            }
            //top neighbor
            if (col - 1 >= 0)
            {
                if (board[row, col - 1] == true)
                    count++;
            }
            //top right neighbor
            if ((col - 1 >= 0) && (row + 1 < numRows))
            {
                if (board[row + 1, col - 1] == true)
                    count++;
            }
            //right neighbor
            if (row + 1 < numRows)
            {
                if (board[row + 1, col] == true)
                    count++;
            }
            //bottom right neighbor
            if ((row + 1 < numRows) && ((col + 1) < numCols))
            {
                if (board[row + 1, col + 1] == true)
                    count++;
            }
            //bottom neighbor
            if (col + 1 < numCols)
            {
                if (board[row, col + 1] == true)
                    count++;
            }
            //bottom left neighbor
            if ((row - 1 >= 0) && (col + 1 < numCols))
            {
                if (board[row - 1, col + 1] == true)
                    count++;
            }
            return count;
        }
        //blinker
        //bool[,] board = new bool[4, 4] {
        //    { false, false, true, false},
        //    { false, false, true, false},
        //    { false, false, true, false},
        //    { false, false, false, false}
        //};

        //bool[,] board1 = new bool[4, 4] {
        //    { false, true, true, false},
        //    { false, true, true, false},
        //    { false, true, true, false},
        //    { false, true, true, false}
        //};
        //for (int i = 1; i < 10; i++)
        //{
        //    Console.WriteLine("Round " + i);
        //    GameOfLife.DrawBoard(board);
        //    Console.WriteLine();
        //    Console.WriteLine("===============");
        //    board = GameOfLife.Start(board);
        //}
    }
}