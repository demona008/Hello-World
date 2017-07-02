using System;


namespace VolleyBall
{
    class Program
    {
        static void Main()
        {
            var str = Console.ReadLine().ToLower();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var broyPlayInWeekends = (48 - h) * 3 / 4;
            var broiPlaysNormal = p*2 / 3  + h + broyPlayInWeekends;
            var broiPlaysLeap = broiPlaysNormal*1.15;
            
            if (str == "leap")
            {
                Console.WriteLine(Math.Truncate(broiPlaysLeap));
            }
            else
            {
                Console.WriteLine(Math.Truncate(broiPlaysNormal));
            }
        }
    }
}
