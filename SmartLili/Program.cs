using System;


namespace SmartLili
{
    class Program
    {
        static void Main()
        {
            var age = int.Parse(Console.ReadLine());
            var pricePeralnq = double.Parse(Console.ReadLine());
            var priceIgrachka = int.Parse(Console.ReadLine());
            var sumBD = 0;
            var broiIgr = 0;
            for (int i = 1; i <= age; i++)
            {
                if ( i%2 ==0)
                {                    
                    sumBD += (i/2*10-1);                                       
                }
                else 
                {
                    broiIgr++;
                }
                
            }
            var totalMoney = sumBD + broiIgr * priceIgrachka;
            if (totalMoney >= pricePeralnq)
            {
                Console.WriteLine($"Yes! {(totalMoney-pricePeralnq):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(pricePeralnq-totalMoney):f2}");
            }
        }
    }
}
