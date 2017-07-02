using System;


namespace AceOfDiamonds
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", new string('*',n));
            var maimunka = 1;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("*{0}{1}{0}*", new string('-',(n-3)/2-i), new string('@',maimunka));
                maimunka += 2;
            }
            var tire = 1;
            for (int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine("*{0}{1}{0}*", new string('-',tire+i), new string('@',n-4-2*i));
            }


            Console.WriteLine("{0}", new string('*', n));
        }
    }
}
