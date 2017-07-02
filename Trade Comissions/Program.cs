using System;


namespace Trade_Comissions
{
    class Program
    {
        static void Main()
        {
            string grad = Console.ReadLine().ToLower();
            var s = double.Parse(Console.ReadLine());
            var commision = -1.0;

            if (grad == "sofia")
            {
                if (0 <= s && s <= 500) commision = 0.05;
                else if (500 < s && s <= 1000) commision = 0.07;
                else if (1000 < s && s <= 10000) commision = 0.08;
                else if (s > 10000) commision = 0.12;
            }
            else if (grad == "varna")
            {
                if (0 <= s && s <= 500) commision = 0.045;
                else if (500 < s && s <= 1000) commision = 0.075;
                else if (1000 < s && s <= 10000) commision = 0.10;
                else if (s > 10000) commision = 0.13;
            }
            else if (grad == "plovdiv")
            {
                if (0 <= s && s <= 500) commision = 0.055;
                else if (500 < s && s <= 1000) commision = 0.08;
                else if (1000 < s && s <= 10000) commision = 0.12;
                else if (s > 10000) commision = 0.145;
            }
            if (commision >= 0)
            {
                Console.WriteLine($"{s * commision:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
