using System;


namespace ElementRavenNaSumOtOstanalite2
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
                sum += currentNumber;
                if (currentNumber > biggestNumber)
                {
                    biggestNumber = currentNumber;
                }
            }
            sum -= biggestNumber;
            if (sum == biggestNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum }");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(sum - biggestNumber)}");
            }
        }
    }
}
