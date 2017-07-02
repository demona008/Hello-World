using System;


namespace Rectangle_with_Stars
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var redove = 0;
            var mid = 0;
            Console.WriteLine("{0}",new string ('%', 2 * n));
            if (n % 2 == 0)
            {
                redove = n - 1;
                mid = redove / 2 + 1;
            }
            else
            {
                redove = n;
                mid = redove / 2 + 1;
            }
            for (int row = 1; row <= redove; row++)
            {
                    if(row == mid)
                    {
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('%', 1), new string(' ', ((2 * n - 2)-2)/2), new string('*',2));
                    }
                    else
                    Console.WriteLine("{0}{1}{0}", new string('%',1),new string(' ',2*n-2));
                
            }
            Console.WriteLine("{0}", new string('%', 2 * n));

        }
    }
}
