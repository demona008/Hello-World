using System;


namespace GradusConverterCToF
{
    class Program
    {
        static void Main()
        {
            var gradusiC = double.Parse(Console.ReadLine());
            var gradusiF = gradusiC * 9 / 5 + 32;
            Console.WriteLine(gradusiF);
        }
    }
}
