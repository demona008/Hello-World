﻿using System;


namespace Factorial
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var fact = 1;

            do
            {
                fact = fact * n;
                n--;
            } while (n > 1);
            Console.WriteLine(fact);
        }
    }
}
