using System;


namespace Profit
{
    class Program
    {
        static void Main()
        {
            int rabotniDni = int.Parse(Console.ReadLine());
            var pariNaDen = double.Parse(Console.ReadLine());
            var kursDolarLev = double.Parse(Console.ReadLine());

            double mesecnaZaplata = rabotniDni * pariNaDen;
            double godishenDohod = mesecnaZaplata * 12 + mesecnaZaplata * 2.5;
            double danak = godishenDohod * 0.25;

            double cistGodishenDohod = godishenDohod - danak;

            double dohodNaDenDolar = cistGodishenDohod / 365;
            double dohodNaDenLeva = dohodNaDenDolar * kursDolarLev;
            

            Console.WriteLine(Math.Round(dohodNaDenLeva,2));
        }
    }
}
