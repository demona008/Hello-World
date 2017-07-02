using System;


namespace ControlNumber
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());
            var sum = 0;
            var counter = 0;
            var result = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int k = m; k >=1; k--)
                {
                    sum = i * 2 + k * 3; counter++;
                    result += sum;
                    if (result >= stop)
                    {
                        Console.WriteLine($"{counter} moves");
                        Console.WriteLine($"Score: {result} >= {stop}");return;
                    }



                }
            }
                               
                        Console.WriteLine($"{counter} moves");

        }
    }
}
