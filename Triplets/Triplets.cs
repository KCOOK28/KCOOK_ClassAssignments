using System;


namespace PythagoreanTriplets
{
    class Triplets
    {
        
       
        static void Main(string[] args)
        {
            //Increases height of COnsole to fit all answers
            Console.BufferHeight = 774;

            // Checking for each 'a' until 500
            for (int a =1; a <= 500; ++a)
            {
                // Checking for each 'b' until 500
                for (int b=1 ; b <= 500; ++b)
                {
                    // Checking for each 'c' until 500
                    for (int c=1 ; c <= 500; ++c)
                    {
                        //Checking if the  equation is true
                        if ((a * a) + (b * b) == (c * c))
                        {
                            //Writes out all possible combinations that are less than 500
                            Console.WriteLine("{0},{1},{2}", a, b, c);
                        }
                    }
                }
            }
            //Display to Console
            Console.Read();
        }

         
        }
}
