using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenaApartament
{
    class Program
    {
        static void Main()
        {
            var naiMalkaStaq = double.Parse(Console.ReadLine());
            var kuhnq = double.Parse(Console.ReadLine());
            var cenaKvadratenMetar = double.Parse(Console.ReadLine());
                        
            var vtoraStaq = naiMalkaStaq * 1.1;
            var tretaStaq = vtoraStaq * 1.1;
            var banq = naiMalkaStaq / 2;
            
            var obhtaPloht = kuhnq + naiMalkaStaq + banq + vtoraStaq + tretaStaq;
            var koridor = obhtaPloht * 0.05;
            var stoinostApartament = cenaKvadratenMetar * (obhtaPloht+koridor);

            Console.WriteLine(Math.Round(stoinostApartament, 2));
                       
        }
    }
}
