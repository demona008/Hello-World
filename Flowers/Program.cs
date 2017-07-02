using System;


namespace Flowers
{
    class Program
    {
        static void Main()
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var laleta = int.Parse(Console.ReadLine());
            var sezon = Console.ReadLine();
            var day = Console.ReadLine();
            var priceBuket = 0.0;
            var totalBroi = hrizantemi + laleta + rozi;
            switch (sezon)
            {
                case "Spring":
                    {
                        switch (day)
                        {
                            case "Y": priceBuket = (hrizantemi * 2 + rozi * 4.1 + laleta * 2.5) * 1.15; break;
                            case "N": priceBuket = hrizantemi * 2 + rozi * 4.1 + laleta * 2.5; break;
                        }
                        if (laleta > 7)
                        {
                            priceBuket *= 0.95;
                        }
                        break;
                    }

                case "Summer":
                    {
                        switch (day)
                        {
                            case "Y": priceBuket = (hrizantemi * 2 + rozi * 4.1 + laleta * 2.5) * 1.15; break;
                            case "N": priceBuket = hrizantemi * 2 + rozi * 4.1 + laleta * 2.5; break;
                        }
                        break;
                    }

                case "Autumn":
                    {
                        switch (day)
                        {
                            case "Y": priceBuket = (hrizantemi * 3.75 + rozi * 4.5 + laleta * 4.15) * 1.15; break;
                            case "N": priceBuket = hrizantemi * 3.75 + rozi * 4.5 + laleta * 4.15; break;
                        }
                        break;
                    }

                case "Winter":
                    {
                        switch (day)
                        {
                            case "Y": priceBuket = (hrizantemi * 3.75 + rozi * 4.5 + laleta * 4.15) * 1.15; break;
                            case "N": priceBuket = hrizantemi * 3.75 + rozi * 4.5 + laleta * 4.15; break;
                        }
                        if (rozi >= 10)
                        {
                            priceBuket *= 0.90;
                        }
                        break;
                    }

            }

            if (totalBroi > 20)
            {
                priceBuket *= 0.8;
                
            }
            priceBuket += 2;
            Console.WriteLine($"{priceBuket:f2}");
        }
    }
}








