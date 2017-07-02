using System;


namespace SumOf3Numbers
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var sum1 = a + b;
            var sum2 = a + c;
            var sum3 = b + c;
        
            if ( sum1 == c && a<=b)
            {
                Console.WriteLine($"{a} + {b} = {c}");
            }
            else if (sum3 == a && a <= b)
            {
                Console.WriteLine($"{b} + {c} = {a}");
            }
            else if (sum2 == b && a <= b)
            {
                Console.WriteLine($"{c} + {a} = {b}");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
