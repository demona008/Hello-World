using System;


namespace SumDigitsInNUmber
{
    class Program
    {
        static void Main()
        {

            var n = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                int currentNumber = n % 10;
                sum += currentNumber;
                n = n / 10;
            } while (n>0);
            Console.WriteLine(sum);
            
        }

    }
}
// var n = console.readline();
// for (int i = 0; i<n.Length; i++)
//{
//int currentDigit = int.Parse(n[1].ToString());
//sum+=currentDigit;
//}
//Console.WriteLine(sum);
//
//