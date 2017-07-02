using System;


namespace Convertor
{
    class Program
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            string from = Console.ReadLine().ToLower();
            string to = Console.ReadLine().ToLower();

            double midBGN = 0;
            double finalMoney = 0;

            if (from == "USD") midBGN = money * 1.79549;
            else if (from == " EUR") midBGN = money * 1.95583;
            else if (from == "GBP") midBGN = money * 2.53405;
            else if (from == " BGN") midBGN = money * 1;
            
            if (to == "USD") finalMoney = midBGN / 1.79549;
            else if (to == " EUR") midBGN = money * 1.95583;
            else if (to == "GBP") midBGN = money * 2.53405;
            else if (to == " BGN") midBGN = money * 1;
            

            Console.WriteLine($"{finalMoney:f2} {to}");
        }
    }
}
