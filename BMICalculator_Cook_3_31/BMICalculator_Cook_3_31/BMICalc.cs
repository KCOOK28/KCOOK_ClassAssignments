﻿using System;


//Grade: 9/10 - You have an issue here because you are using a double value but you are not rounding to any number of digits.  Therefore there can be a calculated bodyMass that is gt 24.9 but less than 25 (ie 24.91)
//You can either use integer for pounds and inches or round your bodyMass calculated value to match your comparison.
    class BMICalc
    {
        static void Main(string[] args)
        {
            double bodyMass;
            double weight;
            double height;

            Console.Write("Enter your weight in pounds >>");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height in inches >>");
            height = Convert.ToDouble(Console.ReadLine());

            bodyMass = ((weight / (height * height)) * 703);

            if (bodyMass < 18.5)
            Console.WriteLine("Your BMI is {0} ", bodyMass + 
                " and according to the scale, you are underweight");

            if (bodyMass >= 18.5 && bodyMass <= 24.9)
            Console.WriteLine("Your BMI is {0} ", bodyMass +  
            "and according to the scale, you are of normal weight");

            if (bodyMass >= 25 && bodyMass <= 29.9)
            Console.WriteLine(" Your BMI is {0} ", bodyMass + 
             " and according to the scale, you are overweight");

            if (bodyMass >= 30)
                Console.WriteLine("Your BMI is {0} ", bodyMass + "and according to the scale you are obese");

            Console.WriteLine();
            Console.WriteLine("BMI Values");
            Console.WriteLine("Underweight:     less then 18.5");
            Console.WriteLine("Normal:          between 18.5 and 24.9");
            Console.WriteLine("Overweight:      between 25 and 29.9");
            Console.WriteLine("Obese:           30 or greater");
            Console.Read();
        }
    }

