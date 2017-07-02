using System;


namespace SoftUniCamp
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;
            var sum = 0.0;
            for (int i = 0; i < n; i++)

            {
                var group = double.Parse(Console.ReadLine());
                
                if (group <= 5) p1+=group;
                if (group > 5 && group <= 12) p2+=group ;
                if (group > 12 && group <= 25) p3+=group ;
                if (group > 25 && group <= 40) p4+=group ;
                if (group > 40) p5+=group;
                 sum += group;
                
            }
            var p1Percent = p1 / sum * 100;
            var p2Percent = p2 / sum * 100;
            var p3Percent = p3 / sum * 100;
            var p4Percent = p4 / sum * 100;
            var p5Percent = p5 / sum * 100;

            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
            Console.WriteLine($"{p4Percent:f2}%");
            Console.WriteLine($"{p5Percent:f2}%");
        }

    }
}
