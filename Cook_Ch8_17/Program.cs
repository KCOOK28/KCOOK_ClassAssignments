using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_Ch8_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // assign Diec One
            int dieOne = 0;
            //asign Dice Two
            int dieTwo = 0;
            //Assign Sum of both die
            int sum = 0;
            //create arrary for possible sums
            int[] sumTotals = new int[13];
            //create array for each dice number


            //create Random object
            Random rand = new Random();

            // loop possible dice rolls
            for (int count = 0; count < 36000; count++)
            {

                //randomize diceOne
                dieOne = rand.Next(1, 7);
                //randomize diceTwo
                dieTwo = rand.Next(1, 7);
                //add both die
                sum = dieOne + dieTwo;
                //put the sums into total sum array
                sumTotals[sum] += 1;

            }

            Console.WriteLine("The total amount of times that each sum was rolled is listed below:");
            Console.WriteLine();
           
           // adds the sum number and the amount of times it occurs
            for (int count = 2; count <= 12; count++)
            {
                Console.WriteLine("{0}: {1}", count, sumTotals[count]);
            }

            Console.Read();
        }
    }
}
