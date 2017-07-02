using System;


namespace Enter_Even_Number
{
    class Program
    {
        static void Main()
        {
            var n = 0;

            while(true)
            {
                try
                {
                    Console.Write("Enter even number:");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                        break;
                        Console.WriteLine("The number is not even.");
                }
                catch
                {
                    Console.WriteLine("Invalid number.");
                }
            }
            Console.WriteLine($"Even number entered: {n}");

        }
    }
}
