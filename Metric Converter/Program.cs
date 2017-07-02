using System;


namespace Metric_Converter
{
    class Program
    {
        static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var vhodMerEd = Console.ReadLine();
            var izhodMerEd = Console.ReadLine();

            if (vhodMerEd == "mm")
            {
                if (izhodMerEd == "cm")
                {
                    Console.WriteLine((0.001 / 0.01) * number + " mm");
                }
                else if (izhodMerEd == "mi")
                {
                    Console.WriteLine(0.001 / (1 / 0.000621371192) * number + " mm");
                }
                else if (izhodMerEd == "in")
                {
                    Console.WriteLine(0.001 / (1 / 39.3700787) * number + " mm");
                }
                else if (izhodMerEd == "km")
                {
                    Console.WriteLine(0.001 / 1000 * number + " mm");
                }
                else if (izhodMerEd == "ft")
                {
                    Console.WriteLine(0.001 / (1 / 3.2808399) * number + " mm");
                }
                else if (izhodMerEd == "yd")
                {
                    Console.WriteLine(0.001 / (1 / 1.0936133) * number + " mm");
                }
                else if (izhodMerEd == "m")
                {
                    Console.WriteLine(0.001 / 1 * number + " mm");
                }
                else if (izhodMerEd == "mm")
                {
                    Console.WriteLine(0.001 / 0.001 * number + " mm");
                }
            }
            else if (vhodMerEd == "cm")
            {
                if (izhodMerEd == "mm")
                {
                    Console.WriteLine((0.01 / 0.001) * number + " cm");
                }
                else if (izhodMerEd == "mi")
                {
                    Console.WriteLine(0.01 / (1 / 0.000621371192) * number + " cm");
                }
                else if (izhodMerEd == "in")
                {
                    Console.WriteLine(0.01 / (1 / 39.3700787) * number + " cm");
                }
                else if (izhodMerEd == "km")
                {
                    Console.WriteLine(0.01 / 1000 * number + " cm");
                }
                else if (izhodMerEd == "ft")
                {
                    Console.WriteLine(0.01 / (1 / 3.2808399) * number + " cm");
                }
                else if (izhodMerEd == "yd")
                {
                    Console.WriteLine(0.01 / (1 / 1.0936133) * number + " cm");
                }
                else if (izhodMerEd == "m")
                {
                    Console.WriteLine(0.01 / 1 * number + " cm");
                }
                else if (izhodMerEd == "cm")
                {
                    Console.WriteLine(0.01 / 0.01 * number + " cm");
                }
            }
            else if (vhodMerEd == "mi")
            {
                if (izhodMerEd == "cm")
                {
                    Console.WriteLine((1 / 0.000621371192) / 0.01 * number + " mi");
                }
                else if (izhodMerEd == "mm")
                {
                    Console.WriteLine((1 / 0.000621371192 / 0.001) * number + " mi");
                }
                else if (izhodMerEd == "in")
                {
                    Console.WriteLine((1 / 0.000621371192) / (1 / 39.3700787) * number + " mi");
                }
                else if (izhodMerEd == "km")
                {
                    Console.WriteLine((1 / 0.000621371192) / 1000 * number + " mi");
                }
                else if (izhodMerEd == "ft")
                {
                    Console.WriteLine((1 / 0.000621371192) / (1 / 3.2808399) * number + " mi");
                }
                else if (izhodMerEd == "yd")
                {
                    Console.WriteLine((1 / 0.000621371192) / (1 / 1.0936133) * number + " mi");
                }
                else if (izhodMerEd == "m")
                {
                    Console.WriteLine((1 / 0.000621371192) / 1 * number + " mi");
                }
                else if (izhodMerEd == "mi")
                {
                    Console.WriteLine(1 * number + " mi");
                }
            }
            else if (vhodMerEd == "in")
            {
                if (izhodMerEd == "cm")
                {
                    Console.WriteLine((1 / 39.3700787) / 0.01 * number + " in");
                }
                else if (izhodMerEd == "mi")
                {
                    Console.WriteLine((1 / 39.3700787) / (1 / 0.000621371192) * number + " in");
                }
                else if (izhodMerEd == "mm")
                {
                    Console.WriteLine((1 / 39.3700787) / 0.001 * number + " in");
                }
                else if (izhodMerEd == "km")
                {
                    Console.WriteLine((1 / 39.3700787) / 1000 * number + " in");
                }
                else if (izhodMerEd == "ft")
                {
                    Console.WriteLine((1 / 39.3700787) / (1 / 3.2808399) * number + " in");
                }
                else if (izhodMerEd == "yd")
                {
                    Console.WriteLine((1 / 39.3700787) / (1 / 1.0936133) * number + " in");
                }
                else if (izhodMerEd == "m")
                {
                    Console.WriteLine((1 / 39.3700787) / 1 * number + " in");
                }
                else if (izhodMerEd == "in")
                {
                    Console.WriteLine(1 * number + " in");
                }
            }
            else if (vhodMerEd == "km")
            {
                if (izhodMerEd == "cm")
                {
                    Console.WriteLine(1000 / 0.01 * number + " km");
                }
                else if (izhodMerEd == "mi")
                {
                    Console.WriteLine(1000 / (1 / 0.000621371192) * number + " km");
                }
                else if (izhodMerEd == "in")
                {
                    Console.WriteLine(1000 / (1 / 39.3700787) * number + " km");
                }
                else if (izhodMerEd == "mm")
                {
                    Console.WriteLine(1000 / 0.001 * number + " km");
                }
                else if (izhodMerEd == "ft")
                {
                    Console.WriteLine(1000 / (1 / 3.2808399) * number + " km");
                }
                else if (izhodMerEd == "yd")
                {
                    Console.WriteLine(1000 / (1 / 1.0936133) * number + " km");
                }
                else if (izhodMerEd == "m")
                {
                    Console.WriteLine(1000 / 1 * number + " km");
                }
                else if (izhodMerEd == "km")
                {
                    Console.WriteLine(1 * number + " km");
                }
            }
            else if (vhodMerEd == "ft")
            {
                if (izhodMerEd == "cm")
                {
                    Console.WriteLine((1 / 3.2808399) / 0.01 * number + " ft");
                }
                else if (izhodMerEd == "mi")
                {
                    Console.WriteLine((1 / 3.2808399) / (1 / 0.000621371192) * number + " ft");
                }
                else if (izhodMerEd == "in")
                {
                    Console.WriteLine((1 / 3.2808399) / (1 / 39.3700787) * number + " ft");
                }
                else if (izhodMerEd == "km")
                {
                    Console.WriteLine((1 / 3.2808399) / 1000 * number + " ft");
                }
                else if (izhodMerEd == "mm")
                {
                    Console.WriteLine((1 / 3.2808399) / 0.001 * number + " ft");
                }
                else if (izhodMerEd == "yd")
                {
                    Console.WriteLine((1 / 3.2808399) / (1 / 1.0936133) * number + " ft");
                }
                else if (izhodMerEd == "m")
                {
                    Console.WriteLine((1 / 3.2808399) / 1 * number + " ft");
                }
                else if (izhodMerEd == "ft")
                {
                    Console.WriteLine(1 * number + " ft");
                }
            }
            else if (vhodMerEd == "yd")
            {
                if (izhodMerEd == "cm")
                {
                    Console.WriteLine((1 / 1.0936133) / 0.01 * number + " yd");
                }
                else if (izhodMerEd == "mi")
                {
                    Console.WriteLine((1 / 1.0936133) / (1 / 0.000621371192) * number + " yd");
                }
                else if (izhodMerEd == "in")
                {
                    Console.WriteLine((1 / 1.0936133) / (1 / 39.3700787) * number + " yd");
                }
                else if (izhodMerEd == "km")
                {
                    Console.WriteLine((1 / 1.0936133) / 1000 * number + " yd");
                }
                else if (izhodMerEd == "ft")
                {
                    Console.WriteLine((1 / 1.0936133) / (1 / 3.2808399) * number + " yd");
                }
                else if (izhodMerEd == "mm")
                {
                    Console.WriteLine((1 / 1.0936133) / 0.001 * number + " yd");
                }
                else if (izhodMerEd == "m")
                {
                    Console.WriteLine((1 / 1.0936133) / 1 * number + " yd");
                }
                else if (izhodMerEd == "yd")
                {
                    Console.WriteLine(1 * number + " yd");
                }
            }
            else if (vhodMerEd == "m")
            {
                if (izhodMerEd == "cm")
                {
                    Console.WriteLine(1 / 0.01 * number + " m");
                }
                else if (izhodMerEd == "mi")
                {
                    Console.WriteLine(1 / (1 / 0.000621371192) * number + " m");
                }
                else if (izhodMerEd == "in")
                {
                    Console.WriteLine(1 / (1 / 39.3700787) * number + " m");
                }
                else if (izhodMerEd == "km")
                {
                    Console.WriteLine(0.001 * number + " m");
                }
                else if (izhodMerEd == "ft")
                {
                    Console.WriteLine(1 / (1 / 3.2808399) * number + " m");
                }
                else if (izhodMerEd == "mm")
                {
                    Console.WriteLine(1 / 0.001 * number + " m");
                }
                else if (izhodMerEd == "yd")
                {
                    Console.WriteLine(1 / (1 / 1.0936133) * number + " m");
                }
                else if (izhodMerEd == "m")
                {
                    Console.WriteLine(1 * number + " m");
                }
            }
        }
    }
}
