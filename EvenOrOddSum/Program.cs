using System;


namespace EvenOrOddSum
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var evenSum = 0.0;
            var oddSum = 0.0;
            for (int i = 0; i < n; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine($"Yes\n = {oddSum }");
            }
            else
            {
                var diff = Math.Abs(oddSum - evenSum);
                Console.WriteLine($"No \n = {diff } ");
            }
        }
    }
}
