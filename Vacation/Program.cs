using System;


namespace Vacation
{
    class Program
    {
        static void Main()
        {
            var adults = double.Parse(Console.ReadLine());
            var students = double.Parse(Console.ReadLine());
            var nights = double.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var priceReservation = nights * 82.99;

            if (transport == "train" && (adults + students) >= 50)
            {
                var priceTransport = (adults * 24.99 + students * 14.99) / 2;
                var sum = (priceTransport*2 + priceReservation) * 1.1;
                Console.WriteLine($"{(sum):f2}");
            }
            else if (transport == "train" && (adults + students) < 50)
            {
                var priceTransport = adults * 24.99 + students * 14.99;
                var sum = (priceTransport*2 + priceReservation) * 1.1;
                Console.WriteLine($"{(sum):f2}");
            }
            else if (transport == "bus")
            {
                var priceTransport = adults * 32.50 + students * 28.50;
                var sum = (priceTransport*2 + priceReservation) * 1.1;
                Console.WriteLine($"{(sum):f2}");
            }
            else if (transport == "boat")
            {
                var priceTransport = adults * 42.99 + students * 39.99;
                var sum = (priceTransport*2 + priceReservation) * 1.1;
                Console.WriteLine($"{(sum):f2}");
            }
            else if (transport == "airplane")
            {
                var priceTransport = adults * 70 + students * 50;
                var sum = (priceTransport*2 + priceReservation) * 1.1;
                Console.WriteLine($"{(sum):f2}");
            }

        }
    }
}
