using System;


namespace MaxCombinations
{
    class Program
    {
        static void Main()
        {
            var start = int.Parse(Console.ReadLine());
            var finish = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = start; i <= finish; i++)
            {
                for (int a = start; a <= finish; a++)
                {
                    if (counter == max) break;
                    else
                    {
                        Console.Write($"<{i}-{a}>");
                        counter++;
                    }
                }
            }
        }
    }
}
