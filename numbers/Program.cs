using System;


namespace HalfSumElement
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var biggestNumber = 0;
            var sum1 = 0;
            for (int i = 0; i < n ; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if ( number > biggestNumber)
                {
                    biggestNumber = number;                             
                    
                }
                sum1 += number;
            }
            var sum = sum1 - biggestNumber;
            var diff = Math.Abs(sum - biggestNumber);
            if ( sum == biggestNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {biggestNumber}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"diff = {diff}");
            }
                
        }
    }
}