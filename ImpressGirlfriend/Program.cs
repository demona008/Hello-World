using System;


namespace ImpressGirlfriend
{
    class Program
    {
        static void Main()
        {
            var rubles = double.Parse(Console.ReadLine())*0.035;
            var dollars = double.Parse(Console.ReadLine()) / 1.5;
            var euro = double.Parse(Console.ReadLine())*1.95;
            var levaB = double.Parse(Console.ReadLine())/2;
            var levaM = double.Parse(Console.ReadLine());

            var maxPrice = Math.Ceiling(Math.Max(levaM, Math.Max(levaB, Math.Max(euro, Math.Max(rubles, dollars)))));

            Console.WriteLine($"{maxPrice:f2}");
        }
    }
}
