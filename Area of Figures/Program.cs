using System;


namespace Area_of_Figures
{
    class Program
    {
        static void Main()
        {
            var figure = Console.ReadLine();

            if ( figure == "square")
            {
              var stranaKvadrat = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ stranaKvadrat* stranaKvadrat}");
            }
            else if ( figure == "rectangle")
            {
                var strana1 = double.Parse(Console.ReadLine());
                var strana2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ strana1 * strana2:f3}");
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ Math.PI * radius*radius:f3}");
            }
            else if (figure == "triangle")
            {
                var strana = double.Parse(Console.ReadLine());
                var visochina = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ strana * visochina/2:f3}");
            }
        }
    }
}
