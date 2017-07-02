using System;


namespace BIkeRace
{
    class Program
    {
        static void Main()
        {
            var juniors = double.Parse(Console.ReadLine());
            var seniors = double.Parse(Console.ReadLine());
            string trace = Console.ReadLine();
            var tax = 0.0;
            switch (trace)
            {
                case "trail": tax = juniors * 5.5 + seniors * 7;break;
                case "cross-country": tax = juniors * 8 + seniors * 9.5; break;
                case "downhill": tax = juniors * 12.25 + seniors * 13.75; break;
                case "road": tax = juniors * 20 + seniors * 21.50; break;
            }
            if(juniors+seniors>=50 && trace == "cross-country")
            {
                tax = tax * 0.75;
            }
            var totalSum = tax * 0.95;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
