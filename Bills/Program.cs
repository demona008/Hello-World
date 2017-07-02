using System;


namespace Bills
{
    class Program
    {
        static void Main()
        {
            var months = double.Parse(Console.ReadLine());
            var elektro = 0.0;
            var water = 0.0;
            var net = 0.0;
            var others = 0.0;
            var sum = 0.0;
            
            for (int i = 0; i < months ; i++)
            {
                var elBill = double.Parse(Console.ReadLine());

                elektro += elBill;
                water += 20;
                net += 15;
                sum = elektro + water + net;
                others = sum * 1.2;
                
            }
              var average = (sum + others) / months;
            Console.WriteLine($"Electricity: {elektro:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {net:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
