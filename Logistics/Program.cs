using System;


namespace Logistics
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var price = 0.0;
            var totalPrice = 0.0;
            var totalTons = 0.0;
            var microbus = 0;
            var kamion = 0;
            var vlak = 0;
            var tons1 = 0.0;
            var tons2 = 0.0;
            var tons3 = 0.0;
            for (int i = 0; i < n; i++)
            {
                var tons = double.Parse(Console.ReadLine());

                if (tons <= 3)
                {
                    price = tons * 200;
                    tons1 += tons;
                    microbus++;
                }
                if (tons >3 && tons <= 11)
                {
                    price = tons * 175;
                    tons2 += tons;
                    kamion++;
                }
                if (tons > 11)
                {
                    price = tons * 120;
                    tons3 += tons;
                    vlak++;
                }

                totalPrice += price;
                totalTons += tons;

            }
            var microbusPercent = tons1 / totalTons * 100;
            var kamionPercent = tons2 / totalTons * 100;
            var vlakPercent = tons3 / totalTons * 100;
            var midPrice = totalPrice / totalTons;

            Console.WriteLine($"{midPrice:f2}");
            Console.WriteLine($"{microbusPercent:f2}%");
            Console.WriteLine($"{kamionPercent:f2}%");
            Console.WriteLine($"{vlakPercent:f2}%");
        }
    }
}
