using System;


namespace Training_room
{
    class Program
    {
        static void Main()
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var broiRedove = Math.Truncate(w / 1.2);
            var broiBura = Math.Truncate((h-1) / 0.7);

            var broiMesta = broiRedove * broiBura - 3;
            Console.WriteLine(broiMesta);
        }
    }
}
