using System;


namespace Парички
{
    class Program
    {
        static void Main()
        {
             var bitkoini = double.Parse(Console.ReadLine());
             var uani = double.Parse(Console.ReadLine());
             var commision = double.Parse(Console.ReadLine());

            var uaniVLeva = uani * 0.15 * 1.76;
            var bitkoiniVLeva = bitkoini * 1168;
            var sumaVEvro = (uaniVLeva + bitkoiniVLeva) / 1.95;
            var sumaCommision = sumaVEvro * commision / 100;
            var sumaVEvroBezCom = sumaVEvro - sumaCommision;
            Console.WriteLine(sumaVEvroBezCom);
        }
    }
}
