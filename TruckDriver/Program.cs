using System;


namespace TruckDriver
{
    class Program
    {
        static void Main()
        {
            var sezon = Console.ReadLine();
            var km = double.Parse(Console.ReadLine());

            if (sezon == "Spring" || sezon == "Autumn")
            {
                if (km<=5000)
                {
                    var salary = 4*km * 0.75 * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else if (km>5000 && km <=10000)
                {
                    var salary = 4*km * 0.95 * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else
                {
                    var salary = 4*km * 1.45 * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
            }
            if (sezon == "Summer")
            {
                if (km <= 5000)
                {
                    var salary = 4*km * 0.90 * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else if (km > 5000 && km <= 10000)
                {
                    var salary = 4*km * 1.10 * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else
                {
                    var salary = 4*km * 1.45 * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
            }
            if (sezon == "Winter")
            {
                if (km <= 5000)
                {
                    var salary = 4*km * 1.05 * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else if (km > 5000 && km <= 10000)
                {
                    var salary = 4*km * 1.25 * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
                else
                {
                    var salary =4* km * 1.45 * 0.9;
                    Console.WriteLine($"{salary:f2}");
                }
            }
        }
    }
}
