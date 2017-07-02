using System;


namespace OddEvenPosition//za check
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var evenSum = 0.0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (i%2 == 0)
                {
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;

                    }
                   evenSum += number;
                }
                                
                else if (i%2!=0)
                {
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;

                    }
                    oddSum += number;
                }
                else if (n==0 || n ==1)
                {

                }
            }
            Console.WriteLine($"OddSum={oddSum}");
            Console.WriteLine($"OddMin={oddMin}");
            Console.WriteLine($"OddMax={oddMax}");
            Console.WriteLine($"EvenSum={evenSum}");
            Console.WriteLine($"EvenMin={evenMin}");
            Console.WriteLine($"EvenMax={evenMax}");
        }
    }
}
