using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a method to simulate rolling a die (returns 1 thru 6)
    public class Dice
    {
        //The Random object must be declared outside of the Roll method.  If it's declared inside of the roll
        //method and the Roll method is called several times in a row, all the die rolls will equal the same
        //number due to the way Random uses the time it's called to generate random numbers.
        Random rand = new Random();

        public int Roll()
        {
            return rand.Next(1, 7);
        }
        ////Call in Program.cs to test
        //Dice dice = new Dice();
        //Console.WriteLine(dice.Roll());
        //Console.WriteLine(dice.Roll());
        //Console.WriteLine(dice.Roll());
        //Console.WriteLine(dice.Roll());
        //Console.WriteLine(dice.Roll());
    }
}
