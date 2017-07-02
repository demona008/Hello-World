using System;


namespace ProspectInHostitality
{
    class Program
    {
        static void Main()
        {
            
            var b = uint.Parse(Console.ReadLine());
            var r = uint.Parse(Console.ReadLine());
            var c = uint.Parse(Console.ReadLine());
            var t = uint.Parse(Console.ReadLine());
            var o = uint.Parse(Console.ReadLine());
            var n = decimal.Parse(Console.ReadLine());
            var u = decimal.Parse(Console.ReadLine());
            var s = decimal.Parse(Console.ReadLine());
            var m = decimal.Parse(Console.ReadLine());

            decimal total = b * 1500.04m + r * 2102.10m + c * 1465.46m + t * 2053.33m + o * 3010.98m + n * u+s;
            Console.WriteLine($"The amount is: {total:f2} lv.");
            if (m>=total)
            {
                Console.WriteLine($"YES \\ Left: {m-total:f2} lv.");
            }
            else
            {
                Console.WriteLine($"NO \\ Need more: {total-m:f2} lv.");
            }
        }
    }
}
