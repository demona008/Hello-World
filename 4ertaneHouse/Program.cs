using System;


namespace _4ertaneHouse
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }
            
            for (int i = 0; i < (n+1)/2; i++)
            {
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - stars) / 2), new string('*', stars));
                stars += 2;
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}",new string('|',1), new string('*',n-2));
            }
        }
    }
}
