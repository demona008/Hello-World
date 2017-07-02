using System;


namespace TrianglePoCisloN
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for ( int row = 1; row < n; row++)
            {
                for ( int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
               //1
               //12
               //123
               //1234
               //12345
               //1....n
        }
    }
}
