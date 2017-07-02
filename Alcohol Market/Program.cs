using System;


namespace Alcohol_Market
{
    class Program
    {
        static void Main()
        {
            var cenaWhisky = double.Parse(Console.ReadLine());
            var biraLitri = double.Parse(Console.ReadLine());
            var vinoLitri = double.Parse(Console.ReadLine());
            var rakiaLitri = double.Parse(Console.ReadLine());
            var whiskyLitri = double.Parse(Console.ReadLine());
            var cenaRakia = cenaWhisky / 2;
            var cenaVino = 0.6 * cenaRakia;
            var cenaBira = 0.2 * cenaRakia;
            var totalPari = cenaWhisky * whiskyLitri + rakiaLitri * cenaRakia + vinoLitri * cenaVino + biraLitri * cenaBira;
            Console.WriteLine($"{totalPari:f2}");

        }
    }
}
