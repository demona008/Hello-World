using System;


namespace Hourglass
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}", new string('*',2*n+1));
            Console.WriteLine(".*{0}*.",new string(' ',2*n-3));
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.',2+i), new string('@',2*n-5-2*i));
            }
            Console.WriteLine("{0}*{0}", new string('.',n));
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}*{1}{2}{1}*{0}", new string('.',n-1-i),new string(' ',i), new string('@',1));
            }
            Console.WriteLine(".*{0}*.", new string('@',2*n-3));

            Console.WriteLine("{0}", new string('*', 2 * n + 1));
        }
    }
}
