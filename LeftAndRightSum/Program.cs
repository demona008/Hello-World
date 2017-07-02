using System;


namespace LeftAndRightSum
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var leftSum = 0.0;
            var rightSum = 0.0;
            for (int i = 0; i < n; i++)
            {
                var currentNumber = Double.Parse(Console.ReadLine());
                leftSum += currentNumber;
            }
            for (int i = 0; i < n; i++)
            {
                var currentNumber = Double.Parse(Console.ReadLine());
                rightSum += currentNumber;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                var diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
