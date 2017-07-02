using System;


namespace Sequence_2k_1
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int i = 0; i < n; i++)
            {
                while (num <= n)
                {
                    Console.WriteLine(num);
                    num = num * 2 + 1;

                }
            }
        }
    }
}
