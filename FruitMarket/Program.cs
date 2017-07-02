using System;


namespace FruitMarket
{
    class Program
    {
        static void Main()//ne e mnogo qsno
        {
            string dayOfWeek = Console.ReadLine();
            var quantity1 = decimal.Parse(Console.ReadLine());
            var product1 = Console.ReadLine();
            var quantity2 = decimal.Parse(Console.ReadLine());
            var product2 = Console.ReadLine();
            var quantity3 = decimal.Parse(Console.ReadLine());
            var product3 = Console.ReadLine();

            var totalPrice = quantity1 * GetPrice(product1, dayOfWeek) +
                quantity2 * GetPrice(product2, dayOfWeek) +
                quantity3 * GetPrice(product3, dayOfWeek);
            Console.WriteLine($"{totalPrice:f2}");
        }

        static decimal GetPrice(string productName, string dayofWeek)
        {
            decimal price = 0;
            bool isFruit = false;
            switch(productName)
            {
                case "banana": price = 1.80m; isFruit = true; break;
                case "cucumber": price = 2.75m;break;
                case "tomato": price = 3.20m; break;
                case "orange": price = 1.60m; isFruit = true; break;
                case "apple": price = 0.86m; isFruit = true; break;
            }
            switch(dayofWeek)
            {
                case "Friday":price = price * 0.90m;break;
                case "Sunday":price = price * 0.95m;break;
                case "Tuesday":
                    if(isFruit)
                    price = price * 0.80m;
                    break;
                case "Wednesday":
                    if (!isFruit)
                        price = price * 0.90m;
                    break;
                case "Thursday":
                    if (productName == "banana")
                        price = price * 0.70m;
                    break;
            }
            return price;
        }
    }
}
