using System;


namespace CakeTycoon
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());//broi cakes
            var c = double.Parse(Console.ReadLine());//kil flour for 1
            var f = double.Parse(Console.ReadLine());//kil flour avilable
            var t = double.Parse(Console.ReadLine());//truffle available
            var p = double.Parse(Console.ReadLine());//price 1 truffle

            var sumTruffles = t * p;
            var neededFlour = f / c;//za 1
            var total = sumTruffles/n;
            if(neededFlour<n)
            {
                Console.WriteLine($"Can make only {Math.Floor(neededFlour)} cakes, need {n*c-f:f2} kg more flour");
            }
            else
            {
                Console.WriteLine($"All products available, price of a cake: {total*1.25:f2}");
            }
        }
    }
}
