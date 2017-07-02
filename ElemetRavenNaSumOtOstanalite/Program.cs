using System;


namespace ElemetRavenNaSumOtOstanalite
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var biggestNumber = double.MinValue;
            var sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber > biggestNumber)
                {
                    if (biggestNumber != double.MinValue)
                    {
                        sum += biggestNumber;
                    }
                    biggestNumber = currentNumber;
                }
                else
                {
                    sum += currentNumber;
                }
            }
            if (biggestNumber == sum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(sum - biggestNumber)}");
            }
        }
    }
}
