using System;


namespace SoftUni_Logo
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dots = ((12 * n - 6) / 2);
            var sharp = 1;
            var dotsLeftDown = 2;
            var dotsRightDown = 3;

            for (int i = 0; i <= 2 * n - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', sharp));
                dots -= 3;
                sharp += 6;
            }
            var sharpDown = 12 * n - 11;
            var lastSharpDown = 0;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', dotsLeftDown),
                    new string('#', sharpDown), new string('.', dotsRightDown));
                sharpDown -= 6;
                dotsLeftDown += 3;
                dotsRightDown += 3;
                lastSharpDown = sharpDown;
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (n == 2)
                {
                    Console.WriteLine("|{0}{1}{2}", new string('.', 2 * n - 2),
                        new string('#', 8 * n - 3), new string('.', 2 * n - 1));
                }
                else
                Console.WriteLine("|{0}{1}{2}", new string('.', (12 * n - 5 - lastSharpDown) / 2 - 1),
                    new string('#', lastSharpDown), new string('.', (12 * n - 5 - lastSharpDown) / 2));
            }
            Console.WriteLine("@{0}{1}{2}", new string('.', 3*n-4), new string('#', 6*n+1), new string('.',3*n-3));
        }


    }
}

