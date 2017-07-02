using System;


namespace EncodedAnswers
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var answerA = 0;
            var answerB = 0;
            var answerC = 0;
            var answerD = 0;
            
            string result= string.Empty;
            for (int i = 0; i < n; i++)
            {
                    var number = uint.Parse(Console.ReadLine());
                    string answer=string.Empty; 
                    if (number % 4 == 0)
                    {
                        answer ="a"; answerA++;
                    }
                    else if (number % 4 == 1)
                    {
                       answer ="b"; answerB++;
                    }
                    else if (number % 4 == 2)
                    {
                        answer ="c"; answerC++;
                    }
                    else if (number % 4 == 3)
                    {
                        answer ="d"; answerD++;
                    }
                result += answer + ' ';
            }
            Console.WriteLine(result);
            Console.WriteLine($"Answer A: {answerA}");
            Console.WriteLine($"Answer B: {answerB}");
            Console.WriteLine($"Answer C: {answerC}");
            Console.WriteLine($"Answer D: {answerD}");
        }
    }
}
