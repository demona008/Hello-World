using System;


namespace DrawFortress
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var gorni = n / 2;
            var dolnoTire = 2 * n - gorni*2-4;
            Console.Write("/{0}\\{1}/{0}\\", new string('^',gorni), new string('_',dolnoTire));


            Console.WriteLine();
            for (int i = 0; i < n-3; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('|',1), new string(' ',2*n-2));
            }
            Console.WriteLine("|{0}{1}{0}|", new string(' ',gorni+1), new string('_',dolnoTire));
            Console.Write("\\{0}/{1}\\{0}/", new string('_', gorni), new string(' ', dolnoTire));

        }
    }
}
