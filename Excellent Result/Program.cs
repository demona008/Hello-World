using System;


namespace Excellent_Result
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());

            if ( a>= 5.50 && a<=6.00)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
