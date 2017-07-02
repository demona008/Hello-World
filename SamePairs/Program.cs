using System;


namespace SamePairs
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var currentSum = 0.0;
            var prevSum = 0.0;
            var diff = 0.0;
            var maxDiff = 0.0;
            for (int i = 0; i < n; i++)
            {
                prevSum = currentSum;
                currentSum = 0;
                currentSum += double.Parse(Console.ReadLine());
                currentSum += double.Parse(Console.ReadLine());

                if (i != 0)
                {
                    diff = Math.Abs(currentSum - prevSum);

                    if (diff != 0 && diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
            }
            
            if (currentSum == prevSum || n == 1)
            {
                Console.WriteLine($"Yes, value={currentSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }

        }
    }
}
