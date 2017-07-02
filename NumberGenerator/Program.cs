using System;


namespace NumberGenerator
{
    class Program
    {
        static void Main()
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var special = int.Parse(Console.ReadLine());
            var kontrolno = int.Parse(Console.ReadLine());


            for (int i = m; i >= 1; i--)
            {
                for (int c = n; c >= 1; c--)
                {
                    for (int j = l; j>= 1; j--)
                    {
                        var number = i * 100 + c * 10 + j; 
                        if (number % 3 == 0)
                        {
                            special += 5;
                        }
                        else if (number % 5 == 0)
                        {
                            special -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            special *= 2;
                        }
                        if (special >= kontrolno) break;
                    }
                    if (special >= kontrolno) break;
                }
                if (special >= kontrolno) break;
            }
            if (special >= kontrolno)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {special}.");
            }

            else
            {

                Console.WriteLine($"No! {special} is the last reached special number.");
            }

        }
    }
}
