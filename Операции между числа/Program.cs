using System;


namespace Операции_между_числа
{
    class Program
    {
        static void Main()
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var oper = Console.ReadLine();


            if (oper == "+")
            {
                var result = n1 + n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {result:00} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} + {n2} = {result:00} - odd");
                }
            }
            if (oper == "-")
            {
                var result = n1 - n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - odd");
                }
            }
            if (oper == "*")
            {
                var result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - odd");
                }
            }
            if (oper == "/")
            {

                var result = (double)n1 / n2;
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
            if (oper == "%")
            {
                var result = n1 % n2;
                if(n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else 
                Console.WriteLine($"{n1} % {n2} = {result}");
            }
        }
    }
}
