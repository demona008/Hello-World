using System;


namespace Battles
{
    class Program
    {
        static void Main()
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var battles = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = 1; i <= first; i++)
            {
                for (int a = 1; a <= second; a++)
                {
                    if (counter == battles) break;
                    else
                    {
                        Console.Write($"({i} <-> {a}) ");
                        counter++;
                    }
                }
            }
        }
    }
}
