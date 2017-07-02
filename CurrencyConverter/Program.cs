using System;


namespace CurrencyConverter
{
    class Program
    {
        static void Main()
        {
            var suma = double.Parse(Console.ReadLine());
            var vhodnaValuta = Console.ReadLine().ToLower();
            var izhodnavaluta = Console.ReadLine().ToLower();


            var bgn = 1;
            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;

            if (vhodnaValuta == "usd" && izhodnavaluta =="eur")
            {
                var final = usd / eur * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "usd" && izhodnavaluta == "gbp")
            {
                var final = usd / gbp * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "usd" && izhodnavaluta == "bgn")
            {
                var final = usd / bgn * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "usd" && izhodnavaluta == "usd")
            {
                var final = usd / usd * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "eur" && izhodnavaluta == "eur")
            {
                var final = eur / eur * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "eur" && izhodnavaluta == "gbp")
            {
                var final = eur / gbp * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "eur" && izhodnavaluta == "bgn")
            {
                var final = eur / bgn * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "eur" && izhodnavaluta == "usd")
            {
                var final = eur / usd * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "gbp" && izhodnavaluta == "eur")
            {
                var final = gbp / eur * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "gbp" && izhodnavaluta == "gbp")
            {
                var final = gbp / gbp * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "gbp" && izhodnavaluta == "bgn")
            {
                var final = gbp / bgn * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "gbp" && izhodnavaluta == "usd")
            {
                var final = gbp / usd * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "bgn" && izhodnavaluta == "eur")
            {
                var final = bgn / eur * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "bgn" && izhodnavaluta == "gbp")
            {
                var final = bgn / gbp * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "bgn" && izhodnavaluta == "bgn")
            {
                var final = bgn / bgn * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
            if (vhodnaValuta == "bgn" && izhodnavaluta == "usd")
            {
                var final = bgn / usd * suma;
                Console.WriteLine(Math.Round(final, 2));
            }
        }
    }
}
