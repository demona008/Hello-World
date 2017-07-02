using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNaCislaOtNdoM
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int number = n;
            decimal product = 1;
            do
            {
                product *= number;
                number++;
            }
            while (number < m);
            Console.WriteLine("Product [n...m] = " + product);
            //1*1=1,1*2=2,2*3=6,6*4=24..
        }
    }
}
