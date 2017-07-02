using System;


namespace Bricks
{
    class Program
    {
        static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());

            var obhtoTuhliNaKurs = m * w;
            var kursove = x / obhtoTuhliNaKurs;
            Console.WriteLine(Math.Ceiling(kursove));
        }
    }
}
