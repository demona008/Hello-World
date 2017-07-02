using System;


namespace FaktorielN
{
    class Program
    {
        static void Main()
        {
            string numberAsString = Console.ReadLine();
            int n = Convert.ToInt32(numberAsString);
            int factorial = 1;
            do
            {
                factorial *= n;
                n--;
            }
            while (n > 0);
            Console.WriteLine("n!= " + factorial);//5*1=5,5*4=20,20*3=60,60*2=120, 120*1=120
        }
    }
}
