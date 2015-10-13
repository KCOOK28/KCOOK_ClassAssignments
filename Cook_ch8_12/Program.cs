using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_Ch8_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int userNumber;
            bool duplicate = false;
            int counter = 0;

            while(counter < 5)
            {
                duplicate = false;
                Console.WriteLine("Enter a number bewteen 10 and 100");
                userNumber = Convert.ToInt32(Console.ReadLine());


                while ( userNumber <10 || userNumber >100)
                {
                    Console.WriteLine("Number Must be between 10 and 100. Enter another number.");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                }

                for(int count = 0; count < 5; count++)
                {
                    if(userNumber == array[count])
                        duplicate = true;
                }

                if(!duplicate)
                    array[counter] = userNumber;

                Console.Write("The Unique numbers are:  ");

                foreach(int element in array)
                {
                    if(element>=10)
                        Console.Write(element + "   ");
                }

                Console.WriteLine();
                counter++;
           }
            Console.Read();
        }
    }
}
