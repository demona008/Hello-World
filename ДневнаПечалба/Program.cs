using System;


namespace ДневнаПечалба
{
    class Program
    {
        static void Main()
        {
             var rabotniDni = double.Parse(Console.ReadLine());
             var pariNaDen = double.Parse(Console.ReadLine());
             var kursDolarLev = double.Parse(Console.ReadLine());

            var dohodNaMesec = rabotniDni * pariNaDen;
            var dohodGodishen = dohodNaMesec * 12 + 2.5*dohodNaMesec;
            var dohodBezDanak = dohodGodishen - dohodGodishen * 0.25;
            var dohodNaDen = dohodBezDanak / 365 * kursDolarLev;
            Console.WriteLine($"{dohodNaDen:f2}");
        }
    }
}
