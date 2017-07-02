using System;


namespace SmallestNumber
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var smallestNumber = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber < smallestNumber)
                {
                    smallestNumber = currentNumber;
                }
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
