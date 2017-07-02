using System;


namespace Time_Plus_15_Minutes
{
    class Program
    {
        static void Main()
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var totalMinutes = minutes + 15;

            if (totalMinutes < 60 && totalMinutes > 10)
            {
                Console.WriteLine($"{hour}:{totalMinutes}");
            }
            else if (totalMinutes >= 60 && (totalMinutes - 60 < 10))
            {
                if (hour + 1 > 23)
                {
                    Console.WriteLine($"0:0{totalMinutes - 60}");
                }
                else
                {
                    Console.WriteLine($"{hour + 1}:0{totalMinutes - 60}");
                }
            }
            else if (totalMinutes >= 60 && (totalMinutes - 60) >= 10)
            {
                if (hour + 1 > 23)
                {
                    Console.WriteLine($"0:{totalMinutes - 60}");
                }
                else
                {
                    Console.WriteLine($"{hour + 1}:{totalMinutes - 60}");
                }
            }
        }
    }
}
