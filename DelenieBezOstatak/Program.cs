using System;


namespace DelenieBezOstatak
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.00;
            var p2 = 0.00;
            var p3 = 0.00;
            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0) p1++;
                if (currentNumber % 3 == 0) p2++;
                if (currentNumber % 4 == 0) p3++;
            }
            var p1Percent = p1 / n * 100;
            var p2Percent = p2 / n * 100;
            var p3Percent = p3 / n * 100;

            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
        } 
    }
}
