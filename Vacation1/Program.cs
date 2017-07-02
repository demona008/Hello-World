using System;


namespace Vacation1
{
    class Program
    {
        static void Main()
        {
            var budjet = double.Parse(Console.ReadLine());
            var sezon = Console.ReadLine();
            
            if (budjet <= 1000)
            {
                if (sezon == "Summer")
                {
                    Console.WriteLine($"Alaska - Camp - {(0.65*budjet):f2}");
                }
                else
                {
                    Console.WriteLine($"Morocco - Camp - {(0.45 * budjet):f2}");
                }
            }
            if (budjet > 1000 && budjet <=3000)
            {
                if (sezon == "Summer")
                {
                    Console.WriteLine($"Alaska - Hut - {(0.80 * budjet):f2}");
                }
                else
                {
                    Console.WriteLine($"Morocco - Hut - {(0.60 * budjet):f2}");
                }
            }
            if (budjet > 3000)
            {
                if (sezon == "Summer")
                {
                    Console.WriteLine($"Alaska - Hotel - {(0.90 * budjet):f2}");
                }
                else
                {
                    Console.WriteLine($"Morocco - Hotel - {(0.90 * budjet):f2}");
                }
            }
        }
    }
}
