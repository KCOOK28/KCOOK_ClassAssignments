using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade 9 out of 10
//Missing requirements
//Write an app that inputs 5 numbers, your app accept inputs until there are 5 unique inputs, this would be a bug
//Use the smallest array possible, the array only needs to hold 4 values because the 5th is the last value and can therefore be output without being stored in the array.
namespace Cook_Ch8_12
{
    class Program
    {
        static void Main(string[] args)
        {

            //creates array with five elements
            int[] array = new int[5];
            //variable for input number
            int userNumber;
            // variable to check if number is duplicated
            bool duplicate = false;
            //counter for the loops
            int counter = 0;

            // loop from 0 tzero to five
            while(counter < 5)
            {
                //start each iteration with false
                duplicate = false;
                Console.WriteLine("Enter a number bewteen 10 and 100");
                userNumber = Convert.ToInt32(Console.ReadLine());

                //checks if number is in range
                while ( userNumber <10 || userNumber >100)
                {
                    Console.WriteLine("Number Must be between 10 and 100. Enter another number.");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                }

                // checks if number is duplicated
                for(int count = 0; count < 5; count++)
                {
                    if(userNumber == array[count])
                        duplicate = true;
                }

                //if not duplicated, put number into array
                if(!duplicate)
                    array[counter] = userNumber;

                Console.Write("The Unique numbers are:  ");

                //writes out number for each array element
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
