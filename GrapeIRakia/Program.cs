using System;


namespace GrapeIRakia
{
    class Program
    {
        static void Main()
        {
            var areaLoze = double.Parse(Console.ReadLine());
            var kgNaKvm = double.Parse(Console.ReadLine());
            var brak = double.Parse(Console.ReadLine());

            var kgGrozde = areaLoze * kgNaKvm - brak;
            var grozdeZaRakia = kgGrozde * 0.45;
            var grozdeZaProdan = kgGrozde * 0.55;
            var litriRakia = grozdeZaRakia / 7.5;

            var prihodRakia = litriRakia * 9.80;
            var prihodGrozde = grozdeZaProdan * 1.50;
            Console.WriteLine($"{prihodRakia:f2}");
            Console.WriteLine($"{prihodGrozde:f2}");
        }
    }
}
