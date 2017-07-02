using System;


namespace Letters_Combinations
{
    class Program
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            var counter = 0;
            for (char i = first; i <= second; i++)
            {

                for (char j = first; j <= second; j++)
                {

                    for (char k = first; k <= second; k++)
                    {

                        if (i != third && j != third && k != third)
                        {
                            Console.Write($"{i}{j}{k} ");
                            counter++;
                        }
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
