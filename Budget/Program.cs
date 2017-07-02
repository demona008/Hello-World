using System;


namespace Budget
{
    class Program
    {
        static void Main()//za proverka
        {
            var n = double.Parse(Console.ReadLine());
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var moneyTotal = n - 150 - 22*10 - (8 -2*h)*20 - (int)(n * 0.03 * p);
            if (moneyTotal>0)
            {
                Console.WriteLine($"Yes, leftover {moneyTotal}.");
            }
            else if (moneyTotal<0)
            {
                Console.WriteLine($"No, not enough {Math.Abs(moneyTotal)}.");
            }
            else
            {
                Console.WriteLine($"Exact Budget.");
            }
        }
    }
}
