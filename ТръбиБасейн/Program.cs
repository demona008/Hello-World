using System;


namespace ТръбиБасейн
{
    class Program
    {
        static void Main()
        {
            var V = double.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());

            var obhtoVZaHchasa = (P1 + P2) * H;
            var procentiPalenObem = Math.Truncate(obhtoVZaHchasa / V * 100);
            var parvaTraba = Math.Truncate(P1*H / obhtoVZaHchasa * 100);
            var vtoraTraba = Math.Truncate(P2*H / obhtoVZaHchasa * 100);

            if (obhtoVZaHchasa <= V)
            {
                Console.WriteLine($"The pool is {procentiPalenObem}% full. Pipe 1: {parvaTraba}%. Pipe 2: {vtoraTraba}%.");
            }
            else if (obhtoVZaHchasa>V)
            {
                Console.WriteLine($"For {H} hours the pool overflows with {obhtoVZaHchasa - V:f1} liters.");
            }
        }
    }
}
