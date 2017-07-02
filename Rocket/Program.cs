using System;


namespace Rocket
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dotsSideUp = (3*n-2)/ 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.',dotsSideUp), new string(' ',2*i));
                dotsSideUp -= 1;
            }
            Console.WriteLine("{0}{1}{0}", new string('.',n/2), new string('*',2*n));
            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.',n/2), new string('\\',2*n-2));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.',n/2-i), new string('*',2*n-2+2*i));
            }
        }
    }
}
