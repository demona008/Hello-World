using System;


namespace Harvest
{
    class Program
    {
        static void Main()
        {
            var xLoze = int.Parse(Console.ReadLine());
            var yGrozdeZaKvMetar = double.Parse(Console.ReadLine());
            var zNujnoVinoLitri = int.Parse(Console.ReadLine());
            var broiRabotnici = int.Parse(Console.ReadLine());

            double obhtoKgGrozde = xLoze * yGrozdeZaKvMetar;
            double grozdeZaVino = obhtoKgGrozde * 0.40;
            double vinoLitri = grozdeZaVino / 2.5;

            if (vinoLitri >= zNujnoVinoLitri)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vinoLitri)} liters.");
                Console.WriteLine($"{Math.Ceiling(vinoLitri - zNujnoVinoLitri)} liters left -> {Math.Ceiling((vinoLitri - zNujnoVinoLitri) / broiRabotnici)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(zNujnoVinoLitri-vinoLitri)} liters wine needed.");
            }


        }
    }
}
