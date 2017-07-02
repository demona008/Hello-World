using System;


namespace Зеленчукова_борса
{
    class Program
    {
        static void Main()
        {
              var cenaZelenchuci = double.Parse(Console.ReadLine());
              var cenaPlodove = double.Parse(Console.ReadLine());
              var kgZelenchuci = int.Parse(Console.ReadLine());
              var kgPlodove = int.Parse(Console.ReadLine());

            var obhtaPechalba = cenaZelenchuci * kgZelenchuci + cenaPlodove * kgPlodove;
            var prihodEvro = obhtaPechalba /1.94;
            Console.WriteLine(prihodEvro);
        }
    }
}
