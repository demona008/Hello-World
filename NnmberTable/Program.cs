using System;


namespace NumberTable
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    var num = i+j;

                    if(num>n)
                    {
                        num = n - num % n;
                    }
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
