using System;


namespace LocalElections
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var vote = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            Console.WriteLine(".............");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("...+{0}+...", new string('-', 5));
                if (i != vote)
                { 
                 Console.WriteLine("...|.....|...");
                 Console.WriteLine("{0}.|.....|...", i.ToString().PadLeft(2, '0'));
                 Console.WriteLine("...|.....|...");
                }
                else
                {
                    if(symbol.ToLower()=="x")
                    {
                        Console.WriteLine("...|.\\./.|...");
                        Console.WriteLine("{1}.|..{0}..|...", symbol.ToUpper(), i.ToString().PadLeft(2, '0'));
                        Console.WriteLine("...|./.\\.|...");
                    }
                    else
                    {
                        Console.WriteLine("...|\\.../|...");
                        Console.WriteLine("{0}.|.\\./.|...", i.ToString().PadLeft(2, '0'));
                        Console.WriteLine("...|..V..|...");
                    }
                }
                Console.WriteLine("...+{0}+...", new string('-', 5));
                Console.WriteLine(new string('.', 13));
            }

        }
    }
}
