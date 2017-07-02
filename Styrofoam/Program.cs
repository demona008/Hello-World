using System;


namespace Styrofoam
{
    class Program
    {
        static void Main()
        {
            var budjet = double.Parse(Console.ReadLine());
            var houseArea = double.Parse(Console.ReadLine());
            var windows = int.Parse(Console.ReadLine());
            var kvMetri = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var area = houseArea - windows * 2.4;
            var totalArea = area * 1.1;
            var paketi = Math.Ceiling(totalArea / kvMetri);
            var sum = paketi * price;

            if ( sum <= budjet)
            {
                Console.WriteLine($"Spent: {sum:f2}");
                Console.WriteLine($"Left: {budjet-sum:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {sum - budjet:f2}");
            }

        }
    }
}
