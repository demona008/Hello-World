using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenchukovaBorsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double stoinostZelenchuci = a * c;
            double stoinostPlodove = b * d;

            double prihodVEvro = (stoinostPlodove + stoinostZelenchuci) / 1.94;
            Console.WriteLine(prihodVEvro);
        }
    }
}
