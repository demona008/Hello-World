using System;


namespace WorkHours
{
    class Program
    {
        static void Main()
        {
            var hours = double.Parse(Console.ReadLine());
            var rabotnici = double.Parse(Console.ReadLine());
            var dni = double.Parse(Console.ReadLine());
            var totalHours = 8 * rabotnici * dni;

            if (totalHours >= hours )
            {
                Console.WriteLine($"{totalHours - hours} hours left");
            }
            else
            {
                Console.WriteLine($"{hours-totalHours} overtime");
                Console.WriteLine($"Penalties: {(hours-totalHours)*dni }");
            }

        }
    }
}
