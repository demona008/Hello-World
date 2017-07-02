using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibnaBorsa
{
    class Program
    {
        static void Main()
        {
            var cenaSkumria = double.Parse(Console.ReadLine());
            var cenaCaca = double.Parse(Console.ReadLine());
            var kgPalamud = double.Parse(Console.ReadLine());
            var kgSafrid = double.Parse(Console.ReadLine());
            var kgMidi = double.Parse(Console.ReadLine());

            var cenapalamud = cenaSkumria *1.6;
            var cenaSafrid = cenaCaca * 1.8;
            var cenaMidi = 7.50;

            var sum = cenapalamud*kgPalamud + cenaSafrid*kgSafrid + cenaMidi*kgMidi;
            Console.WriteLine($"{sum:f2}");

        }
    }
}
