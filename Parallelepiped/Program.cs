﻿using System;


namespace Parallelepiped
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("+{0}+{1}", new string('~',n-2),new string('.',2*n+1));
            for (int i = 0; i < 2*n+1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.',i),new string('~',n-2), new string('.',2*n-i));
            }
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', i), new string('.', 2 * n-i), new string('~', n - 2));
            }
            Console.WriteLine("{0}+{1}+",new string ('.',2*n+1), new string ('~',n-2));
        }
    }
}
