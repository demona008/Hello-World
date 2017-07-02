using System;


namespace lekcia
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var greatestNumber = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber>greatestNumber)
                {
                    greatestNumber = currentNumber;
                }
            }
            Console.WriteLine(greatestNumber);
        }
    }
}
