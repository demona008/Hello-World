using System;


namespace BuyTank
{
    class Program
    {
        static void Main()
        {
            var priceTank = int.Parse(Console.ReadLine());
            var partyDays = int.Parse(Console.ReadLine());
            
            var monthlySavings = (30-partyDays) * 2 - partyDays * 5;
            
            double neededTimeInMonths = (double)priceTank / monthlySavings;
            int result = (int)Math.Ceiling(neededTimeInMonths);
            var years = result / 12;
            var months = result % 12;

            if ( monthlySavings<=0)
            {
                Console.WriteLine("never");
            }
            else
            {
                Console.WriteLine($"{years} years {months} months");
            }

        }
    }
}
