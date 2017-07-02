using System;
using System.Globalization;


namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main()
        {
                        
            DateTime birthdayDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            birthdayDate = birthdayDate.AddDays(999);
            Console.WriteLine(birthdayDate.ToString("dd-MM-yyyy"));

        }
    }
}
