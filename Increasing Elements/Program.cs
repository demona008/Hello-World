using System;


namespace Increasing_Elements
{
    class Program
    {
        static void Main()
        {
            var n = double.Parse(Console.ReadLine());
            var counter = 0;
            var startNumber = 0.0;
            var maxCounter = 0;

            for (int i = 0; i < n; i++)
            {

                var number = double.Parse(Console.ReadLine());
 
                if (number > startNumber)
                {
                    counter++;

                }
                else
                    counter = 1;
                if(counter>maxCounter)
                {
                    maxCounter = counter;
                }
                startNumber = number;    
            }
            Console.WriteLine(maxCounter);
            
        }
    }
}
