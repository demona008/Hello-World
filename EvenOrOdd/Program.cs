using System;


namespace EvenOrOdd
{
    class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var even = (num % 2 == 0);
            if ( even)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
