using System;


namespace ChristmasHat
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var tire = 1;
            var dot = (4*n-4)/2;
            Console.WriteLine("{0}/|\\{0}", new string('.',(4*n-2)/2));
            Console.WriteLine("{0}\\|/{0}", new string('.', (4 * n - 2) / 2));
            Console.WriteLine("{0}***{0}", new string('.', (4 * n - 2) / 2));
            for (int i = 0; i < 2*n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",new string('.',dot),new string('-',tire));
                dot--;
                tire++;
            }
            Console.WriteLine("{0}", new string('*',4*n+1));
            for (int i = 0; i < 1; i++)
            {
                Console.Write("*");
                for (int c = 0; c < 2*n; c++)
                {
                    Console.Write(".*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("{0}", new string('*', 4 * n + 1));
        }
    }
}
