using System;


namespace _2DAreaRectangle
{
    class Program
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var stranaX = Math.Abs(x1 - x2);
            var stranaY = Math.Abs(y1 - y2);

            var area = stranaX * stranaY;
            var perimeter = 2 * stranaX + 2 * stranaY;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
