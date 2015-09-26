using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class ClimbingStairs
    {
        //A child is running up a staircase with n steps, and can hop either 1, 2, or 3 steps at a time.  Implement a method to count how many possible ways the child can run up the stairs.
        //Source: Crack Coding Interview p. 316
        //Caching solution: https://www.youtube.com/watch?v=YTdhH5Uk06E
        //Answer will overflow integer datatype(over 4 billion) at 37 steps

        //Recursive solution
        public static int CombosRecursive(int numStairs)
        {
            if (numStairs <= 0)
                return 0;
            if (numStairs == 1)
                return 1;
            if (numStairs == 2)
                return 2;
            if (numStairs == 3)
                return 4;
            return CombosRecursive(numStairs - 1) + CombosRecursive(numStairs - 2) + CombosRecursive(numStairs - 3);
        }

        //Iterative solution with caching
        public static int CombosIterative(int numStairs)
        {
            if (numStairs <= 0)
                return 0;
            if (numStairs == 1)
                return 1;
            if (numStairs == 2)
                return 2;
            if (numStairs == 3)
                return 4;
            int[] prev = { 1, 2, 4 };

            //We only start caching results if numStairs is more than 3
            int current = 3;
            while (current < numStairs)
            {
                int preTotal = prev[0] + prev[1] + prev[2];
                prev[0] = prev[1];
                prev[1] = prev[2];
                prev[2] = preTotal;
                current++;
            }
            return prev[2];
        }
        //Stopwatch stopwatch = new Stopwatch();
        //stopwatch.Start();
        //Console.WriteLine("StairClimbing 35 ways Recursive: " + ClimbingStairs.CombosRecursive(37));
        //stopwatch.Stop();
        //Console.WriteLine("Time used(Recursive): " + stopwatch.ElapsedMilliseconds);

        //Stopwatch stopwatch2 = new Stopwatch();
        //stopwatch2.Start();
        //Console.WriteLine("Stair Climbing 35 ways Iterative: " + ClimbingStairs.CombosIterative(37));
        //stopwatch2.Stop();
        //Console.WriteLine("Time used(Iterative): " + stopwatch2.ElapsedMilliseconds);
    }
}