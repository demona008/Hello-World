using System;


namespace RentCar
{
    class Program
    {
        static void Main()
        {
            var budjet = double.Parse(Console.ReadLine());
            var sezon = Console.ReadLine();

            if ( budjet <=100)
            {
                if (sezon == "Summer")
                {
                    Console.WriteLine($"Economy class");
                    Console.WriteLine($"Cabrio - {(0.35*budjet):f2}");
                }
                else
                {
                    Console.WriteLine($"Economy class");
                    Console.WriteLine($"Jeep - {(0.65 * budjet):f2}");
                }
            }
            if (budjet >100 && budjet <= 500)
            {
                if (sezon == "Summer")
                {
                    Console.WriteLine($"Compact class");
                    Console.WriteLine($"Cabrio - {(0.45 * budjet):f2}");
                }
                else
                {
                    Console.WriteLine($"Compact class");
                    Console.WriteLine($"Jeep - {(0.80 * budjet):f2}");
                }
            }
            if (budjet > 500)
            {                              
                    Console.WriteLine($"Luxury class");
                    Console.WriteLine($"Jeep - {(0.90 * budjet):f2}");
            }
        }
    }
}
