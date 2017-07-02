using System;


namespace ProstiCisla
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if( n<2)
            {
                isPrime = false;
            }
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not Prime");
            
        }
    }
}
