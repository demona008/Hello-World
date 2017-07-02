using System;


namespace SchoolCamp
{
    class Program
    {
        static void Main()//za check
        {
            string vacationType = Console.ReadLine();
            string groupType = Console.ReadLine();
            var studentNumber = int.Parse(Console.ReadLine());
            var nightNumber = int.Parse(Console.ReadLine());

            if (vacationType == "Winter" && groupType == "boys")
            {
                if (studentNumber >= 50)
                {
                    Console.WriteLine($"Judo {9.6 * studentNumber * nightNumber / 2:f2} lv.");
                }
            }
            else if (vacationType == "Winter" && groupType == "girls" && studentNumber >= 50)
            {
                Console.WriteLine($"Gymnastics {9.6 * studentNumber * nightNumber / 2:f2} lv.");
            }
            else if (vacationType == "Winter" && groupType == "mixed" && studentNumber >= 50)
            {
                Console.WriteLine($"Ski {10 * studentNumber * nightNumber / 2:f2} lv.");
            }
            else if (vacationType == "Winter" && groupType == "boys" && studentNumber>=20 && studentNumber < 50)
            {
                Console.WriteLine($"Judo {9.6 * studentNumber * 0.85 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Winter" && groupType == "girls" && studentNumber >= 20 && studentNumber < 50)
            {
                Console.WriteLine($"Gymnastics {9.6 * studentNumber *0.85 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Winter" && groupType == "mixed" && studentNumber >= 20 && studentNumber < 50)
            {
                Console.WriteLine($"Ski {10 * studentNumber *0.85 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Winter" && groupType == "boys" && studentNumber >= 10 && studentNumber < 20)
            {
                Console.WriteLine($"Judo {9.6 * studentNumber *0.95 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Winter" && groupType == "girls" && studentNumber >= 10 && studentNumber < 20)
            {
                Console.WriteLine($"Gymnastics {9.6 * studentNumber *0.95 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Winter" && groupType == "mixed" && studentNumber >= 10 && studentNumber < 20)
            {
                Console.WriteLine($"Ski {10 * studentNumber *0.95 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Winter" && groupType == "boys" &&  studentNumber < 10)
            {
                Console.WriteLine($"Judo {9.6 * studentNumber * nightNumber:f2} lv.");
            }
            else if (vacationType == "Winter" && groupType == "girls" && studentNumber < 10)
            {
                Console.WriteLine($"Gymnastics {9.6 * studentNumber * nightNumber:f2} lv.");
            }
            else if (vacationType == "Winter" && groupType == "mixed" && studentNumber < 10)
            {
                Console.WriteLine($"Ski {10 * studentNumber * nightNumber:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "boys" && studentNumber >= 50)
            {
                Console.WriteLine($"Tennis {7.2 * studentNumber / 2 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "girls" && studentNumber >= 50)
            {
                Console.WriteLine($"Athletics {7.2 * studentNumber * nightNumber / 2:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "mixed" && studentNumber >= 50)
            {
                Console.WriteLine($"Cycling {9.5 * studentNumber * nightNumber / 2:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "boys" && studentNumber >= 20 && studentNumber < 50)
            {
                Console.WriteLine($"Tennis {7.2 * studentNumber * 0.85 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "girls" && studentNumber >= 20 && studentNumber < 50)
            {
                Console.WriteLine($"Athletics {7.2 * studentNumber * 0.85 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "mixed" && studentNumber >= 20 && studentNumber < 50)
            {
                Console.WriteLine($"Cycling {9.5 * studentNumber * 0.85 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "boys" && studentNumber >= 10 && studentNumber < 20)
            {
                Console.WriteLine($"Tennis {7.2 * studentNumber * 0.95 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "girls" && studentNumber >= 10 && studentNumber < 20)
            {
                Console.WriteLine($"Athletics {7.2 * studentNumber * 0.95 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "mixed" && studentNumber >= 10 && studentNumber < 20)
            {
                Console.WriteLine($"Cycling {9.5 * studentNumber * 0.95 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "boys" && studentNumber < 10)
            {
                Console.WriteLine($"Tennis {7.2 * studentNumber * nightNumber:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "girls" && studentNumber < 10)
            {
                Console.WriteLine($"Athletics {7.2 * studentNumber * nightNumber:f2} lv.");
            }
            else if (vacationType == "Spring" && groupType == "mixed" && studentNumber < 10)
            {
                Console.WriteLine($"Cycling {9.5 * studentNumber * nightNumber:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "boys" && studentNumber >= 50)
            {
                Console.WriteLine($"Football {15 * studentNumber * nightNumber / 2:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "girls" && studentNumber >= 50)
            {
                Console.WriteLine($"Voleyball {15 * studentNumber / 2:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "mixed" && studentNumber >= 50)
            {
                Console.WriteLine($"Swimming {20 * studentNumber * nightNumber / 2:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "boys" && studentNumber >= 20 && studentNumber < 50)
            {
                Console.WriteLine($"Football {15 * studentNumber * 0.85 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "girls" && studentNumber >= 20 && studentNumber < 50)
            {
                Console.WriteLine($"Voleyball {15 * studentNumber * 0.85 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "mixed" && studentNumber >= 20 && studentNumber < 50)
            {
                Console.WriteLine($"Swimming {20 * studentNumber * 0.85 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "boys" && studentNumber >= 10 && studentNumber < 20)
            {
                Console.WriteLine($"Football {15 * studentNumber * 0.95 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "girls" && studentNumber >= 10 && studentNumber < 20)
            {
                Console.WriteLine($"Voleyball {15 * studentNumber * 0.95 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "mixed" && studentNumber >= 10 && studentNumber < 20)
            {
                Console.WriteLine($"Swimming {20 * studentNumber * 0.95 * nightNumber:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "boys" && studentNumber < 10)
            {
                Console.WriteLine($"Football {15 * studentNumber * nightNumber:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "girls" && studentNumber < 10)
            {
                Console.WriteLine($"Volleyball {15 * studentNumber * nightNumber:f2} lv.");
            }
            else if (vacationType == "Summer" && groupType == "mixed" && studentNumber < 10)
            {
                Console.WriteLine($"Swimming {20 * studentNumber * nightNumber:f2} lv.");
            }

        }
    }
}
