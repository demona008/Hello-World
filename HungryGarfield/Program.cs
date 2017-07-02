using System;


namespace HungryGarfield
{
    class Program
    {
        static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());
            var rate = decimal.Parse(Console.ReadLine());
            var pizzaPrice = decimal.Parse(Console.ReadLine())/rate;
            var lasagnaPrice = decimal.Parse(Console.ReadLine())/rate;
            var sandwichPrice = decimal.Parse(Console.ReadLine())/rate;
            var pizzaQuantity = decimal.Parse(Console.ReadLine());
            var lasagnaQuantity = decimal.Parse(Console.ReadLine());
            var sandwichQuantity = decimal.Parse(Console.ReadLine());
            
            var totalCost = pizzaPrice * pizzaQuantity + lasagnaPrice * lasagnaQuantity + sandwichPrice* sandwichQuantity;

            if(money-totalCost>=0)
            {
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${money-totalCost:f2}.");
            }
            else
            {
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${totalCost-money:f2}.");
            }
        }
    }
}
