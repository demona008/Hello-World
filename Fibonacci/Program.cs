﻿using System;


namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            
            var n = int.Parse(Console.ReadLine());
            var f0 = 1;
            var f1 = 1;
            for (int i = 0; i < n-1; i++)
            {
                var fnext = f0 + f1;
                f0 = f1;
                f1 = fnext;
            }
            Console.WriteLine(f1);
        }
    }
}
