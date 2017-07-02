using System;


namespace Bonus_Score
{
    class Program
    {
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var bonusPoint = 0.0;
            var even = (number % 2 == 0);
            var naPet = (number % 10 == 5);
            if (number <= 100)
            {
                bonusPoint = 5;
                if (even)
                {
                    bonusPoint = bonusPoint + 1;

                }
                if (naPet)
                {
                    bonusPoint = bonusPoint + 2;
                }
            }
            else if (number > 100 && number <= 1000)
            {
                bonusPoint = 0.2 * number;
                if (even)
                {
                    bonusPoint = bonusPoint + 1;

                }
                if (naPet)
                {
                    bonusPoint = bonusPoint + 2;
                }
            }
            else if (number > 1000)
            {
                bonusPoint = 0.1 * number;
                if (even)
                {
                    bonusPoint = bonusPoint + 1;

                }
                if (naPet)
                {
                    bonusPoint = bonusPoint + 2;
                }
            }

            Console.WriteLine(bonusPoint);
            Console.WriteLine(number + bonusPoint);
        }
    }
}
