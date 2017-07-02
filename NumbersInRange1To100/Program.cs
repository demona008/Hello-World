﻿using System;


namespace NumbersInRange1To100
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number in the range [1...100]:");
            var n = int.Parse(Console.ReadLine());

            while( n<1 || n>100 )
            {
                Console.WriteLine("Invalid number!");
                n = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"The number is: {n}");
        }
    }
}
