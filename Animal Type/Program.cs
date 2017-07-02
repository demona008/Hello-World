using System;


namespace Animal_Type
{
    class Program
    {
        static void Main()
        {
            string animal = Console.ReadLine().ToLower();

            switch (animal)
            {

                case "dog":Console.WriteLine("mammal"); break;
                case "crocodile":Console.WriteLine("reptile"); break;
                case "tortoise":Console.WriteLine("reptile"); break;
                case "snake":Console.WriteLine("reptile"); break;                  
                default: if (animal!="dog" && animal!="crocodile" && animal!="tortoise" && animal!="snake")
                     
                     Console.WriteLine("unknown"); break;
                                         
            }
        }
    }
}
