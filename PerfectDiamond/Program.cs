using System;


namespace PerfectDiamond
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var tire = 1;
            var space = (2 * n - 1) / 2; ;
            for (int row = 1; row <= n; row++)
            {
                Console.Write("{0}{1}", new string(' ', space), new string('*', 1));
                space--;
                for (int col = 0; col <= row-2; col++)
                {
                    tire = 1;
                    Console.Write("{0}", new string('-', tire));
                    Console.Write("*");
                    
                }

                Console.WriteLine();
            }
            for (int row = n-1; row >= 1; row--)
            {
                space = n-row;
                Console.Write("{0}{1}", new string(' ', space), new string('*', 1));
                
                for (int col = 0; col <= row-2; col++)
                {
                    tire = 1;
                    Console.Write("{0}", new string('-', tire));
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
