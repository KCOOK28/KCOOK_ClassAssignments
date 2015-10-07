using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_8_Assignment
{
    class ParkingFees
    {


        static void Main(string[] args)
        {
            
            const double MIN_FEE = 2.0;
            const double EXTRA_FEE = .5;
            const double MAX_FEE = 10.0;
            
            int custAmt;
            double finalPrice;
            double total = 0.0;


            Console.WriteLine("How many customers parked yesterday?");
            custAmt = Convert.ToInt32(Console.ReadLine());
            for (int count = 1; count <= custAmt; count++)
            {
                Console.WriteLine("Enter amount of hourse parked for Customer #{0}", count);
                int hours = Int32.Parse(Console.ReadLine());
               
                if (hours <= 3)
                {
                    finalPrice = MIN_FEE;
                    total += finalPrice;
                    Console.WriteLine("Customer #{0} total fee is: {1:C}.", count, finalPrice);
                    Console.WriteLine("Total Reciepts: {0:C}.", total);
                }
                else if ((hours > 3) && (hours != 24))
                {
                    finalPrice = MIN_FEE + ((hours - 3) * EXTRA_FEE);
                    total += finalPrice;
                    Console.WriteLine("Customer #{0} total fee is: {1:C}.", count, finalPrice);
                    Console.WriteLine("Total Reciepts: {0:C}.", total);
                }

                else if (hours == 24)
                {
                    finalPrice = MAX_FEE;
                    total += finalPrice;
                    Console.WriteLine("Customer #{0} total fee is: {1:C}.", count, finalPrice);
                    Console.WriteLine("Total Reciepts: {0:C}.", total);
                }

            }
            Console.Read();
        }

    }
}
