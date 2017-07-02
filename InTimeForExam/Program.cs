using System;


namespace InTimeForExam
{
    class Program
    {
        static void Main()
        {
            var startIzpit = int.Parse(Console.ReadLine());
            
            var minuteIzpit = int.Parse(Console.ReadLine());
            var hPristigane = int.Parse(Console.ReadLine());
            var minutePristigane = int.Parse(Console.ReadLine());

            TimeSpan startTime = new TimeSpan(startIzpit, minuteIzpit, 0);
            TimeSpan arriveTime = new TimeSpan( hPristigane, minutePristigane, 0);
            TimeSpan difference = startTime - arriveTime;

                int hours = int.Parse(difference.Hours.ToString());
                int minutes = int.Parse(difference.Minutes.ToString());
            if (startTime > arriveTime &&  Math.Abs(minutes) <= 30 && Math.Abs(minutes)>=1 && hours<1)
            {
                Console.WriteLine($"On time");
                Console.WriteLine($"{minutes:0} minutes before the start");
            }
            else if (startTime> arriveTime && Math.Abs(hours)>=1)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{hours}:{minutes:00} hours before the start");
            }
            else if (startTime > arriveTime && Math.Abs(minutes) >30 && Math.Abs(minutes)<60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{minutes:00} minutes before the start");
            }
            else if (startTime < arriveTime && Math.Abs(hours) >= 1)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Abs(hours)}:{Math.Abs(minutes):00} hours after the start");
            }
            else if (startTime < arriveTime && Math.Abs(minutes) < 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Abs(minutes):0} minutes after the start");
            }
            else if (startTime == arriveTime)
            {
                Console.WriteLine($"On time");
            }
            
        }
    }
}
