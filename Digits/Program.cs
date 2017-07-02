using System;


namespace Digits
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var first = n / 100;
            var second = n/10 % 10;
            var third = n % 10;
            var redove = first + second;
            var koloni = first + third;
            for (int i = 0; i < redove; i++)
            {
                for (int a = 1; a <= koloni; a++)
                {
                    if(n%5==0)
                    {
                        n -= first;
                    }
                    else if(n%3==0)
                    {
                        n -= second;
                    }
                    else
                    {
                        n += third;
                    }
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }

        }
    }
}
