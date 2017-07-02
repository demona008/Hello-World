using System;


namespace SumsStep3
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var sum1 = 0.0;
            var sum2 = 0.0;
            var sum3 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (i % 3 == 0) sum1 += number;
                if (i % 3 == 1) sum2 += number;
                if (i % 3 == 2) sum3 += number;
                
            }

            Console.WriteLine($"sum1 = {sum1}");
            Console.WriteLine($"sum2 = {sum2}");
            Console.WriteLine($"sum3 = {sum3}");
        }
    }
}
