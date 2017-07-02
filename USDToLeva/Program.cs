using System;


namespace RadiansToGradusiC
{
    class Program
    {
        static void Main()
        {
            var dolari = double.Parse(Console.ReadLine());
            var leva = dolari * 1.79549;
            Console.WriteLine(Math.Round(leva, 2));
        }
    }
}
