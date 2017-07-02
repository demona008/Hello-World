using System;


namespace ChangeTiles
{
    class Program
    {
        static void Main()
        {
             var sabraniPari = double.Parse(Console.ReadLine());
             var shirinaPod = double.Parse(Console.ReadLine());
             var daljinaPod = double.Parse(Console.ReadLine());
             var stranaPlochka = double.Parse(Console.ReadLine());
             var hPlochka = double.Parse(Console.ReadLine());
             var priceTile = double.Parse(Console.ReadLine());
             var sumaMaistor = double.Parse(Console.ReadLine());

             var areaPod = shirinaPod * daljinaPod;
             var areaPlochka = stranaPlochka * hPlochka / 2;
             var neededPlochki = Math.Ceiling(areaPod / areaPlochka);
             var totalPlochki = neededPlochki + 5;
             var sumaPlochki = totalPlochki * priceTile;
             var totalMoney = sumaMaistor + sumaPlochki;
            if(totalMoney<=sabraniPari)
            {
                Console.WriteLine($"{sabraniPari-totalMoney:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {totalMoney-sabraniPari:f2} lv more.");
            }
        }
    }
}
