using System;


namespace HousePainting
{
    class Program
    {
        static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var areaSteni = 2 * (x * y - 1.5 * 1.5) + x * x + (x * x - 1.2 * 2);
            var areaPokriv = 2 * x * y + 2 * h * x / 2;
            var zelenaBoq = areaSteni / 3.4;
            var redBoq = areaPokriv / 4.3;

            Console.WriteLine($"{zelenaBoq:f2}");
            Console.WriteLine($"{redBoq:f2}");
        }
    }
}
