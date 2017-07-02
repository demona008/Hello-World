using System;


namespace РемонтПлочки
{
    class Program
    {
        static void Main()
        {
            var N = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var O = double.Parse(Console.ReadLine());

            var areaPlohtadka = N * N;
            var areaPlocki = W * L;
            var areaPeika = M * O;

            var areaBezPeika = areaPlohtadka - areaPeika;
            var neobhodimiPlochki = areaBezPeika / areaPlocki;
            var vremeZaPostavqne = neobhodimiPlochki * 0.2;
            Console.WriteLine(neobhodimiPlochki);
            Console.WriteLine(vremeZaPostavqne);
        }
    }
}
