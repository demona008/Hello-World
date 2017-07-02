using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintWith2VariablesUsingFor
{
    class Program
    {
        static void Main()
        {
            for ( int i = 1, sum = 1; i <= 128; i = i*2, sum +=i)
            {
                Console.WriteLine(" i = {0}, sum = {1}", i, sum);
            }
        }
    }
}
