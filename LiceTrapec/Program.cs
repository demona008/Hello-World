using System;


namespace LiceTrapec
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var areaTrapec = (a + b) * h / 2;
            Console.WriteLine(areaTrapec);
                    }
    }
}
