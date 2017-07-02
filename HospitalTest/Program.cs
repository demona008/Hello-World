using System;


namespace HospitalTest
{
    class Program
    {
        static void Main()
        {
            var period = int.Parse(Console.ReadLine());
            var lekari = 7;
            var treatedPatients = 0;
            var untreatedPatient = 0;

            for (int i = 1; i <= period; i++)
            {
                var n = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreatedPatient > treatedPatients)
                {
                    lekari++;
                }
                if (n<lekari)
                {
                    treatedPatients += n;
                    untreatedPatient += 0;
                }
                if(n==lekari)
                {
                    treatedPatients += lekari;
                    untreatedPatient += 0;

                }
                if(n>lekari)
                {
                    treatedPatients += lekari;
                    untreatedPatient += n - lekari;

                }


            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatient}.");
        }
    }
}
