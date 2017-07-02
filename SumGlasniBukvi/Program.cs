using System;


namespace SumGlasniBukvi
{
    class Program
    {
        static void Main()
        {
            var word = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var currentLetter = word[i];
                switch (currentLetter)
                {
                    case 'a': sum++; break;
                    case 'e': sum += 2; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                    case 'i': sum += 3; break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
