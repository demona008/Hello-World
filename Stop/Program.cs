using System;


namespace Stop
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dots = n;
            var tireta = 2 * n - 1; 
            var dolniDots = 1;
            var dolniTireta = 4 * n+3 -6;
            Console.WriteLine("{0}{1}{0}", new string('.',n+1), new string('_',2*n+1));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.',dots), new string('_',tireta));
                dots--;
                tireta += 2;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_',(4*n+3-9)/2));
            Console.WriteLine("\\\\{0}//", new string('_', 4 * n +3- 4));
            for (int i = 0; i < n-1; i++)
            {
                
                Console.WriteLine("{0}\\\\{1}//{0}",new string('.',dolniDots), new string('_',dolniTireta));
                dolniDots++;
                dolniTireta -= 2;
            }
        }

    }
}
