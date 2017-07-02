using System;


namespace TrainerSalary
{
    class Program
    {
        static void Main()
        {
            var lekcii = double.Parse(Console.ReadLine());
            var budjet = double.Parse(Console.ReadLine());
            var jelev = 0;
            var royal = 0;
            var roli = 0;
            var trofon = 0;
            var sino = 0;
            var others = 0;
            for (int i = 0; i < lekcii ; i++)
            {
                var lektor = Console.ReadLine();
                if (lektor == "Jelev") jelev++;
                if (lektor == "RoYaL") royal++;
                if (lektor == "Roli") roli++;
                if (lektor == "Trofon") trofon++;
                if (lektor == "Sino") sino++;
                if (lektor != "Jelev" && lektor != "RoYaL" && lektor != "Roli" && lektor != "Trofon" && lektor != "Sino") others++;
            }
            var jelevSalary = jelev * budjet / lekcii;
            var royalSalary = royal  * budjet / lekcii;
            var roliSalary = roli * budjet / lekcii;
            var trofonSalary = trofon  * budjet / lekcii;
            var sinoSalary = sino * budjet / lekcii;
            var othersSalary = others  * budjet / lekcii;
            Console.WriteLine($"Jelev salary: {jelevSalary:f2} lv");
            Console.WriteLine($"RoYaL salary: {royalSalary:f2} lv");
            Console.WriteLine($"Roli salary: {roliSalary:f2} lv");
            Console.WriteLine($"Trofon salary: {trofonSalary:f2} lv");
            Console.WriteLine($"Sino salary: {sinoSalary:f2} lv");
            Console.WriteLine($"Others salary: {othersSalary:f2} lv");

        }
    }
}
