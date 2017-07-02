using System;


namespace _4ertaneDiamond
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var tireta = (n-1) / 2; ;
            
            for (int i = 1; i <= (n-1)/2; i++)
            {
                Console.Write(new string('-',tireta));
                Console.Write("*");
                var mid = n - 2 * tireta - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', tireta));
                tireta--;
            }
            
            for (int i = 0; i <= (n-1)/2; i++)
            {
                Console.Write(new string('-', tireta));
                Console.Write("*");
                var mid = n - 2 * tireta - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', tireta));
                tireta++;
            }
        }
    }
}
