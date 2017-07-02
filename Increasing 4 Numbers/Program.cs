using System;


namespace Increasing_4_Numbers
{
    class Program
    {
        static void Main()// za dovarshvane
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if(a>=b-2)
            {
                Console.WriteLine("No");return;
            }

            for (int i = a; i <= b; i++)
            {
                
                for (int k = i+1; k <= b; k++)
                {
                    
                    for (int l = k+1; l <=b; l++)
                    {
                        
                        for (int m = l+1; m <= b; m++)
                        {

                            Console.WriteLine($"{i} {k} {l} {m}");
                            

                        }
                    }
                }

            }

        }
    }
}
