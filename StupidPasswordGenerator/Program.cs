using System;


namespace StupidPasswordGenerator
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                for (int c = 1; c <= n; c++)
                {
                    for (int b = 'a'; b < 97+l; b++)
                    {
                        for (int d = 'a'; d < 97+l; d++)
                        {
                            for (int k = Math.Max(i,c)+1; k <= n; k++)
                            {
                                Console.Write($"{i}{c}{Convert.ToChar(b)}{Convert.ToChar(d)}{k} ");
                            }

                        }
                    }
                }
                
            }

        }
    }
}
