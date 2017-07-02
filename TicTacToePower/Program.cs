using System;


namespace TicTacToePower
{
    class Program
    {
        static void Main()
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var v = int.Parse(Console.ReadLine());//index1

            long result = 0;
            int position = x + 1;
            if ( y == 1)
            {
                position = x + 4;
            }
            if ( y==2)
            {
                position = x + 7;
            }
            v += position - 1;
            result = (long)Math.Pow(v, position);
            Console.WriteLine(result);
        }
    }
}
