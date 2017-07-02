using System;


namespace ToyShop//za check
{
    class Program
    {
        static void Main()
        {
            var tripPrice = double.Parse(Console.ReadLine());
            var pazeli = double.Parse(Console.ReadLine());
            var kukli = double.Parse(Console.ReadLine());
            var mecheta = double.Parse(Console.ReadLine());
            var minioni = double.Parse(Console.ReadLine());
            var kamioni = double.Parse(Console.ReadLine());

            var totalSumBez = pazeli * 2.6 + kukli * 3 + mecheta * 4.1 + minioni * 8.2 + kamioni * 2;
            var totalSum = totalSumBez * 0.9;
            var broiIgrachki = pazeli + kukli + mecheta + minioni + kamioni;
            var totalSumSOtstapkaBez = totalSumBez * 0.75;
            var totalSumSOtstapka = totalSumSOtstapkaBez * 0.9;
            if (broiIgrachki>=50)
            {
                
                if ( totalSumSOtstapka>tripPrice)
                {
                    Console.WriteLine($"Yes! {totalSumSOtstapka - tripPrice:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {tripPrice - totalSumSOtstapka:f2} lv needed.");
                }
            }
            else
            {
                if (totalSum > tripPrice)
                {
                    Console.WriteLine($"Yes! {totalSum - tripPrice:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {tripPrice - totalSum:f2} lv needed.");
                }
            }

        }
    }
}
