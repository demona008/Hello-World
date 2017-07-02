using System;


namespace TransportPrice
{
    class Program
    {
        static void Main()
        {
            var km = double.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            if( time =="day")
            {
                if (km>=20 && km<100)
                {
                    Console.WriteLine( 0.09 * km);
                }
                else if( km>=100)
                {
                    Console.WriteLine(0.06 * km);
                }
                else if ( km<20)
                {
                    Console.WriteLine(0.70 + 0.79 * km);
                }
            }
            else if ( time == "night")
            {
                if (km >= 20 && km < 100)
                {
                    Console.WriteLine(0.09 * km);
                }
                else if (km >= 100)
                {
                    Console.WriteLine(0.06 * km);
                }
                else if (km < 20)
                {
                    Console.WriteLine(0.70 + 0.90 * km);
                }
            }
        }
    }
}
