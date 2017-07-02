using System;


namespace HotelRoom
{
    class Program
    {
        static void Main()
        {
            var month = Console.ReadLine();
            var num = int.Parse(Console.ReadLine());

            if (num <= 7)
            {
                if (month == "May" || month == "October")
                {
                    var totalApartment = num * 65;
                    var totalStudio = num * 50;
                    Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
                    Console.WriteLine($"Studio: {totalStudio:f2} lv.");
                }
                else if (month == "June" || month == "September")
                {
                    var totalApartment = num * 68.70;
                    var totalStudio = num * 75.20;
                    Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
                    Console.WriteLine($"Studio: {totalStudio:f2} lv.");

                }
                else
                {
                    var totalApartment = num * 77;
                    var totalStudio = num * 76;
                    Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
                    Console.WriteLine($"Studio: {totalStudio:f2} lv.");
                }
            }
            else if (num > 7 && num <= 14)
            {
                if (month == "May" || month == "October")
                {
                    var totalApartment = num * 65;
                    var totalStudio = num * 50 * 0.95;
                    Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
                    Console.WriteLine($"Studio: {totalStudio:f2} lv.");
                }
                else if (month == "June" || month == "September")
                {
                    var totalApartment = num * 68.70;
                    var totalStudio = num * 75.20;
                    Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
                    Console.WriteLine($"Studio: {totalStudio:f2} lv.");
                }
                else
                {
                    var totalApartment = num * 77;
                    var totalStudio = num * 76;
                    Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
                    Console.WriteLine($"Studio: {totalStudio:f2} lv.");
                }

            }
            else
            {
                if (month == "May" || month == "October")
                {
                    var totalApartment = num * 65*0.9;
                    var totalStudio = num * 50*0.7;
                    Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
                    Console.WriteLine($"Studio: {totalStudio:f2} lv.");
                }
                else if (month == "June" || month == "September")
                {
                    var totalApartment = num * 68.70*0.9;
                    var totalStudio = num * 75.20*0.8;
                    Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
                    Console.WriteLine($"Studio: {totalStudio:f2} lv.");
                }
                else
                {
                    var totalApartment = num * 77*0.9;
                    var totalStudio = num * 76;
                    Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
                    Console.WriteLine($"Studio: {totalStudio:f2} lv.");
                }
            }

        }
    }
}
