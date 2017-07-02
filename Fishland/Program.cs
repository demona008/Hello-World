using System;


namespace Pets
{
    class Program
    {
        static void Main()
        {
            var days = double.Parse(Console.ReadLine());
            var totalFood = double.Parse(Console.ReadLine());
            var dogFood = double.Parse(Console.ReadLine());
            var catFood = double.Parse(Console.ReadLine());
            var turtleFoodGram = double.Parse(Console.ReadLine());
            var turtleFood = turtleFoodGram / 1000;

            var neededFood = (dogFood + catFood + turtleFood) * days;

            if ( totalFood >= neededFood)
            {
                Console.WriteLine($"{Math.Floor(totalFood -neededFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(neededFood-totalFood)} more kilos of food are needed.");
            }
        }
    }
}
