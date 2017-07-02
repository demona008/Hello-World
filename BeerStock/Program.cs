using System;


namespace IlluminatiLock
{
    class Program
    {
        static void Main()
        {
            var n= int.Parse(Console.ReadLine());
            var dotsGore = 2;
            var dotsDolu = n - 3;
            Console.WriteLine("{0}{1}{0}", new string('.',n), new string('#',n));
            Console.WriteLine("{0}###{0}###{0}", new string('.', n-2));
            for (int i = 0; i < (n-3)/2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.',n-4-2*i),new string('.',dotsGore),
                    new string('.', n-2));
                dotsGore += 2;
            }
            var edgeDot = 1;
            for (int i = 0; i < (n - 3) / 2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', edgeDot), new string('.', dotsDolu),
                    new string('.', n - 2));
                dotsDolu -= 2;
                edgeDot += 2;
            }



            Console.WriteLine("{0}###{0}###{0}", new string('.', n - 2));
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
        }
    }
}
