using System;


namespace TheBetterMusicProducer
{
    class Program
    {
        static void Main()
        {
            var numberAlbumsInEurope = int.Parse(Console.ReadLine());
            var priceInEuro = double.Parse(Console.ReadLine());
            var numberAlbumsInNAmerica = int.Parse(Console.ReadLine());
            var priceInDollar = double.Parse(Console.ReadLine());
            var numberAlbumsInSAmerica = int.Parse(Console.ReadLine());
            var priceInPesos = double.Parse(Console.ReadLine());
            var numberOfConcerts = int.Parse(Console.ReadLine());
            var profitSingleConcertInEuro = double.Parse(Console.ReadLine());

            var prihodInEuropeInLeva = numberAlbumsInEurope * priceInEuro * 1.94;
            var prihodInNAmericaInLeva = numberAlbumsInNAmerica * priceInDollar * 1.72;
            var priceInSAmericaInLeva = numberAlbumsInSAmerica * priceInPesos / 332.74;

            var prihodObhtoOtConcerts = prihodInEuropeInLeva + prihodInNAmericaInLeva + priceInSAmericaInLeva;
            var prihodBezProducerTaxes = prihodObhtoOtConcerts - prihodObhtoOtConcerts * 0.35;
            var finalPrihodBezTaxes = prihodBezProducerTaxes - prihodBezProducerTaxes * 0.2;

            var prihodObhtoConcerts = numberOfConcerts * profitSingleConcertInEuro*1.94;
            if (prihodObhtoConcerts>100000)
            {
                prihodObhtoConcerts -= prihodObhtoConcerts * 0.15;
            }

            if (finalPrihodBezTaxes>prihodObhtoConcerts)
            {
                Console.WriteLine($"Let's record some songs! They'll bring us {finalPrihodBezTaxes:f2}lv.");
            }
            else
            {
                Console.WriteLine($"On the road again! We'll see the world and earn {prihodObhtoConcerts:f2}lv.");
            }
        }

    }
}
