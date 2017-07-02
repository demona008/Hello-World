using System;


namespace BackToThePast
{
    class Program
    {
        static void Main()
        {
            var money = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var yearsToLive = year - 1800;
            var sumEven = 0.0;
            var sumOdd = 0.0;
            for (int i = 0; i <= yearsToLive; i++)
            {
                if (i % 2 == 0)
                {
                   sumEven += 12000;
                }
                else
                {
                    sumOdd += 12000 + 50 * (18 + i);
                }                
            }
            var moneyLeft = money - (sumEven + sumOdd);
            if (moneyLeft>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyLeft:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(moneyLeft):f2} dollars to survive.");
            }                        
        }
    }
}
