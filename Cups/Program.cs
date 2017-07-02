using System;


namespace Cups
{
    class Program
    {
        static void Main()
        {
            var numberCups = double.Parse(Console.ReadLine());
            var ranotnici = double.Parse(Console.ReadLine());
            var dni = double.Parse(Console.ReadLine());
            var totalHours = ranotnici * dni * 8;
            var izraboteniCups = Math.Truncate(totalHours / 5);
            var izraboteniMoney = izraboteniCups * 4.2;
            var neededMoney = numberCups * 4.2;
            var profit = izraboteniMoney - neededMoney;
            var losses = neededMoney - izraboteniMoney;
            if ( izraboteniCups  >= numberCups )
            {
                Console.WriteLine($"{profit:f2} extra money");
            }
            else
            {
                Console.WriteLine($"Losses: {losses:f2}");
            }
        }
    }
}
