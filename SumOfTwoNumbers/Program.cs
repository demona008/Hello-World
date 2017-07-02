using System;


namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = a; i >= b; i--)
            {
                for (int j = a; j >= b; j--)
                {

                    if (i + j != c) counter++;
                    
                    if (i + j == c)
                    {
                        counter++;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {c})");
                        return;
                    }

                }

            }
            Console.WriteLine($"{counter} combinations - neither equals {c}");
        }
    }
}
