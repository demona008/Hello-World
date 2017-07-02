using System;


namespace PointOnSegment
{
    class Program
    {
        static void Main()
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            var point = double.Parse(Console.ReadLine());
            if ((point>=first && point<= second) || (point<=first && point>=second))
            {
                Console.WriteLine("in");
                if (Math.Abs(first - point)>=(second - point))
                {
                    Console.WriteLine(Math.Abs(second-point));
                }
                else
                {
                    Console.WriteLine(Math.Abs(first-point));
                }
            }
            else
            {
                Console.WriteLine("out");
                if (Math.Abs(first - point) >= (Math.Abs(second-point)))
                {
                    Console.WriteLine(Math.Abs(point - second));
                }
                else
                {
                    Console.WriteLine(Math.Abs(first - point));
                }
            }
        }
    }
}
