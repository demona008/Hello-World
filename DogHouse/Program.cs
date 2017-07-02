using System;


namespace DogHouse
{
    class Program
    {
        static void Main()
        {
            var A = double.Parse(Console.ReadLine());
            var B = double.Parse(Console.ReadLine());
            var areaPokriv = ( 2 * A * A / 2 );
            var areaSteni = (2*A*A/2+A/2*A/2+A/2*(B - A / 2) / 2+A/2*(B-A/2)/2+(A/2*A/2-A/5*A/5));
            Console.WriteLine($"{areaSteni/3:f2}");
            Console.WriteLine($"{areaPokriv/5:f2}");
        }
    }
}
