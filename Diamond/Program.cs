using System;


namespace Diamond
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dotsEndUp = n - 1;
            var dotsMiddleUp = 3 * n;
            var dotsEndDown = 1;
            var dotsMiddleDown = 5 * n-4;
            var starsDown = n-2;
            Console.WriteLine("{0}{1}{0}", new string('.',n), new string('*',3*n));
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('.',dotsEndUp), new string('.',dotsMiddleUp));
                dotsEndUp--;
                dotsMiddleUp += 2;
            }
            Console.WriteLine("{0}", new string('*',5*n));
            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.',dotsEndDown),new string('.',dotsMiddleDown));
                dotsEndDown++;
                dotsMiddleDown -= 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.',(5*n-(n-2))/2), new string('*',starsDown));
        }
    }
}
