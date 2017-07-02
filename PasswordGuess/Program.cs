using System;


namespace PasswordGuess
{
    class Program
    {
        static void Main()
        {
            var password = Console.ReadLine();

            if ("s3cr3t!P@ssw0rd" == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
