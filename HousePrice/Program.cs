using System;


namespace HousePrice
{
    class Program
    {
        static void Main()
        {
            var areaSmallRoom = double.Parse(Console.ReadLine());
            var areaKitchen = double.Parse(Console.ReadLine());
            var priceM2 = double.Parse(Console.ReadLine());
            var bathroom = areaSmallRoom / 2;
            var secondRoom = areaSmallRoom * 1.1;
            var thirdRoom = secondRoom * 1.1;

            var areaRooms = areaSmallRoom + areaKitchen + bathroom + secondRoom + thirdRoom;
            var coridor = areaRooms * 0.05;
            var priceTotal = (areaRooms + coridor) * priceM2;
            Console.WriteLine($"{priceTotal:f2}");
        }
    }
}
