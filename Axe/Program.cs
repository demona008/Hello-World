using System;


namespace Axe
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var middleAxe = 1;
            var end = 1;
            
            Console.WriteLine("{0}**{1}", new string('-',3*n),new string('-',2*n-2));
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('-',3*n),new string('-',middleAxe),new string('-',2*n-2-middleAxe));
                middleAxe++;
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('*',3*n),new string('-',n-1), new string('-',n-1));
            }
            for (int i = 0; i < (n-2)/2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('-',3*n-i), new string('-',middleAxe-1),new string('-', n- end));
                middleAxe+=2;
                end++;
                if(i==(n-2)/2-1)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - i-1), new string('*', middleAxe-1), new string('-', n-end));
                }

            }
            if (n == 2)
            {
                Console.WriteLine("{0}***-", new string('-', 3 * n));
            }
        }
    }
}
