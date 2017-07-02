using System;


namespace SumSeconds
{
    class Program
    {
        static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var x1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var timeInSeconds = x + x1 + x2;
           
            if( timeInSeconds<10)
            {
                Console.WriteLine($"{Math.Truncate(timeInSeconds / 60)}:0{timeInSeconds % 60}");
            }
            else if ( timeInSeconds%60<10)
            {
                Console.WriteLine($"{Math.Truncate(timeInSeconds / 60)}:0{timeInSeconds % 60}");
            }
            else
            {
                Console.WriteLine($"{Math.Truncate(timeInSeconds / 60)}:{timeInSeconds % 60}");
            }
        }
    }
}
