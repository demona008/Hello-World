using System;


namespace TriangleeArea
{
    class Program
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var h = y1 - y2;
            var a = x2 - x3;
            var area = a * h / 2;
            Console.WriteLine(Math.Abs(area));

        }
    }
}
