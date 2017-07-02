using System;


namespace FallenInLove
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dots = 1;
            Console.WriteLine("##{0}##{0}##", new string('.',2*n));
            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~', i),
                    new string('.',2*n-2*i), new string('.',2*i));
            }
            var middleDots = 2 * n;
            var kriva = n;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.',dots),
                    new string('~',kriva), new string('.',middleDots-2*i));
                dots += 2;
                kriva--;
            }
            Console.WriteLine("{0}####{0}", new string('.',2*n+1));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}##{0}", new string('.',2*n+2));
            }
        }
    }
}
