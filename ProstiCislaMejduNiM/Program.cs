using System;


namespace ProstiCislaMejduNiM
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int num = n; num <= m; num++)
            {
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(num);
                while ( divider <= maxDivider)
                {
                    if ( num%divider==0)
                    {
                        prime = false;
                        break;
                    }
                    divider++;
                }
                if (prime)
                {
                    Console.WriteLine(" " + num);
                }
            }

        }
    }
}
