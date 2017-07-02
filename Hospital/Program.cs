using System;


namespace Hospital
{
    class Program
    {
        static void Main()
        {
            var period = int.Parse(Console.ReadLine());
            var doctors = 7;
            var Treated = 0;
            var Untreated = 0;
            for (int i = 1; i <= period; i++)
            {
                var numberPatients = int.Parse(Console.ReadLine());
                
                if ((i % 3 == 0) && Untreated> Treated)
                {
                    doctors++;
                }
                if (numberPatients > doctors)
                {
                    Treated += doctors;
                    Untreated += numberPatients - doctors;
                }
                else
                {
                    Treated += numberPatients;
                }

            }
            Console.WriteLine($"Treated patients: {Treated}.");
            Console.WriteLine($"Untreated patients: {Math.Abs(Untreated)}.");
        }
    }
}
