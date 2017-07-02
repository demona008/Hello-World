using System;


namespace Trip
{
    class Program
    {
        static void Main()
        {
            var budjet = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();

            if (0<budjet && budjet <= 100)
            {
                if (sezon == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budjet * 0.3:f2}");
                }
                if (sezon == "winter")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budjet * 0.7:f2}");
                }
            }
             else if (100 < budjet && budjet <= 1000)
                    {
                       if (sezon == "summer")
                       {
                          Console.WriteLine("Somewhere in Balkans");
                          Console.WriteLine($"Camp - {budjet * 0.4:f2}");
                       }
                       if (sezon == "winter")
                       {
                          Console.WriteLine("Somewhere in Balkans");
                          Console.WriteLine($"Hotel - {budjet * 0.8:f2}");
                       }
                     }
            else 
              {                
                Console.WriteLine("Somewhere in Europe");                             
                Console.WriteLine($"Hotel - {budjet * 0.9:f2}");
              }
        }
    }
}
