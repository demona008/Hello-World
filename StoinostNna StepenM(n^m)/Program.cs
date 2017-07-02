using System;


namespace StoinostNna_StepenM_n_m_
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            decimal result = 1;
            for (int i = 0; i < m; i++) 
            {
                result *= n;
            }
            Console.WriteLine("n^m = " + result);//2.4; 1*2=2;2*2=4;4*2=8;8*2=16
        }
    }
}
