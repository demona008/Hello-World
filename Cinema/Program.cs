using System;


namespace Cinema
{
    class Program
    {
        static void Main()
        {
            string projekcia = Console.ReadLine();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (projekcia == "Premiere")
            {
                Console.WriteLine($"{r * c * 12:f2} leva");
            }
            else if ( projekcia == "Normal")
            {
                Console.WriteLine($"{r * c * 7.50:f2} leva");
            }
            else if ( projekcia == "Discount")
            {
                Console.WriteLine($"{r * c * 5.00} leva");
            }
        }
    }
}
