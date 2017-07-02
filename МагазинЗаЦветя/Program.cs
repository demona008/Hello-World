using System;


namespace МагазинЗаЦветя
{
    class Program
    {
        private static object EndpointRounding;

        static void Main()
        {
            var broiMagnolii = int.Parse(Console.ReadLine());
            var broiZumbuli = int.Parse(Console.ReadLine());
            var broiRozi = int.Parse(Console.ReadLine());
            var broiKaktusi = int.Parse(Console.ReadLine());
            var cenaPodarak = double.Parse(Console.ReadLine());

            var magnolii = 3.25;
            var zumbuli = 4;
            var rozi = 3.50;
            var kaktusi = 8;

            double pechalbaObhto = broiMagnolii * magnolii + broiZumbuli * zumbuli + broiRozi * rozi + broiKaktusi * kaktusi;
            double pechalbaSledDanaci = pechalbaObhto*0.95;
            double ostatak = Math.Abs(Math.Floor(pechalbaSledDanaci - cenaPodarak));

            Console.WriteLine(pechalbaSledDanaci >= cenaPodarak ? "She is left with {0} leva." : "She will have to borrow {0} leva.", ostatak);
        }
    }
}
