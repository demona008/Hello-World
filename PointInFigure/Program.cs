using System;


namespace PointInFigure
{
    class Program
    {
        static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var sideF1 = ((x >= 2 && x <= 4 && (y == -3 || y == 1)) || ((x == 2 || x==4) && y >= -3 && y <= 1))||(x>2&&x<4&&y>-3&&y<1);
            var sideF2 = ((x >= 10 && x <= 12 && (y == -3 || y == 1)) || ((x == 10 || x == 12) && y >= -3 && y <= 1))||(x>10&&x<12&&y>-3&&y<1);
            var bigF = ((x >= 4 && x <= 10 && (y == -5 || y == 3)) || ((x == 4 || x == 10) && y >= -5 && y <= 3))||(x>4&&x<10&&y>-5&&y<3);
            if (sideF1 || sideF2 || bigF)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
