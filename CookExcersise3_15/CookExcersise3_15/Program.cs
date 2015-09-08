using System;



    class Arithmetic
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int sum;
            int diff;
            int prod;
            float quot;

            Console.Write("Enter the first integer >>");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second interger >>");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine(" Sum is {0}", sum);

            diff = num1 - num2;
            Console.WriteLine(" The Differnece is {0}", diff);

            prod = num1 * num2;
            Console.WriteLine(" The Product is {0}", prod);

            quot = num1 / num2;
            Console.WriteLine(" The Quotient is {0}", quot);
            
Console.Read();

        }
    }