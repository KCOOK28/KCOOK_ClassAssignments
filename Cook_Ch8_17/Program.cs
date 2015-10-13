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
            int dieOne = 0;
            int dieTwo = 0;
            int sum = 0;
            int[] sumTotals = new int[13];
            int[,] dieNumbers = new int[7, 7];

            Random rand = new Random();

            for(int count = 0;  count < 36000; count++)
            {
                dieOne = rand.Next(1, 7);
                dieTwo = rand.Next(1, 7);
                sum = dieOne + dieTwo;
                sumTotals[sum] += 1;
                dieNumbers[dieOne, dieTwo] += 1;

            }

            Console.WriteLine("The total amount of times that each sum was rolled is listed below:");
            Console.WriteLine();
            for(int count = 2; count <= 12; count++)
            {
                Console.WriteLine("{0}: {1}", count, sumTotals[count]);
            }

            Console.Read();
        }
    }
}
