using System;


namespace Crown
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("@{0}@{0}@", new string(' ',(2*n-4)/2));
            Console.WriteLine("**{0}*{0}**",new string(' ',(2*n-6)/2));
            var dotEnd = 1;
            var dotMiddle = 1;
            var space = (2 * n - 10) / 2;
            for (int i = 0; i < n/2-2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.',dotEnd), new string(' ',space),new string('.',dotMiddle));
                dotEnd++;
                space -= 2;
                dotMiddle += 2;
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('.',(n-2)/2), new string('.',n-3));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.',n/2), new string('*',(n-4)/2));
            Console.WriteLine("{0}",new string('*',2*n-1));
            Console.WriteLine("{0}", new string('*', 2 * n - 1));
        }
    }
}
