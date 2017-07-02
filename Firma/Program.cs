using System;


namespace Firma
{
    class Program
    {
        static void Main()
        {
            var hours = double.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());
            var hora = double.Parse(Console.ReadLine());
            var totalDays = days * 0.9;
            var totalHours = Math.Truncate(totalDays * 8 + days * 2 * hora);

            if (totalHours >= hours)
            {
                Console.WriteLine($"Yes!{totalHours - hours} hours left.");
            }
            else if ( totalHours<hours)
            {
                Console.WriteLine($"Not enough time!{Math.Abs(totalHours - hours)} hours needed.");
            }
        }
    }
}
