﻿using System;


namespace StopNumber
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if(i%2==0 && i%3==0)
                {
                    if(i==s)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"{i} ");
                    }
                }
            }

        }
    }
}
