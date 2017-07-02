using System;


namespace Invalid_Number
{
    class Program
    {
        static void Main()//za check za drug sravnenie
        {
            var x = double.Parse(Console.ReadLine());

            if (x < 100 && x != 0)
            {
                Console.WriteLine("invalid");
            }
            else if (x > 200)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
