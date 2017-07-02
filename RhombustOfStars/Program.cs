using System;


namespace RhombustOfStars
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string (' ', n-i));
                
                for (int c = 0; c < i; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                                
            }
            for (int i = n-1; i >=1; i--)
            {
                Console.Write(new string(' ', n-i));

                for (int c = 0; c < i; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
                        
        }
    }
}
