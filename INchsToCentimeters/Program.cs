using System;


namespace INchsToCentimeters
{
    class Program
    {
        static void Main()
        {
            var inches = Double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
