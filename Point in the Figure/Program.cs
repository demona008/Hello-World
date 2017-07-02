using System;


namespace Point_in_the_Figure
{
    class Program
    {
        static void Main()
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var downFigure = (x > 0 && x < 3 * h && y > 0 && y < h)||(x>h&&x<2*h&&y==h);
            var upFigure = x > h && x < 2 * h && y > h && y < 4 * h;
            var borderYDownFigure = (x == 0 || x == 3 * h) && (y >= 0 && y <= h);
            var borderXDownFigure = (y == 0 || y == h) && (x >= 0 && x <= 3 * h);
            var borderYUpFigure = (x == h || x == 2 * h) && (y >= h && y <= 4 * h);
            var borderXUpFigure = (y == h || y == 4 * h) && (x >= h && x <= 2 * h);

            if (downFigure || upFigure)
            {
                Console.WriteLine("inside");
            }
            else if (borderXDownFigure || borderXUpFigure || borderYUpFigure || borderYDownFigure)
            {
                Console.WriteLine("border");

            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}