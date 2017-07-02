using System;


namespace SleepyCatTom
{
    class Program
    {
        static void Main()
        {
            var restDays = int.Parse(Console.ReadLine());

            var igraVPochivniGodishno = 127 * restDays;
            var igraVRabotniGodishno =  (365-restDays)*63;
            var igraGodishno = igraVPochivniGodishno + igraVRabotniGodishno;
            var razlika = Math.Abs(igraGodishno - 30000);
            var hours = razlika / 60;
            var minutes = razlika % 60;
            if ( igraGodishno > 30000 )
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
