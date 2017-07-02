using System;


namespace RadiansToGradusiC
{
    class Program
    {
        static void Main()
        {
            var radiani = double.Parse(Console.ReadLine());
            var gradusi = radiani * 180 / Math.PI;
            Console.WriteLine(Math.Round(gradusi));
        }
    }
}
