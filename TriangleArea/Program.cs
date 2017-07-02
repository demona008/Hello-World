using System;


namespace TriangleArea
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = a * h / 2;
            Console.WriteLine($"{area:f2}");

        }
    }
}
