using System;


namespace MatchTickets
{
    class Program
    {
        static void Main()
        {
            var budjet = double.Parse(Console.ReadLine());
            var kategory = Console.ReadLine();
            var people = double.Parse(Console.ReadLine());
            var neededMoneyVip = people * 499.99;
            var neededMoneyNormal = people * 249.99;
            if (people <= 4)
            {
                var leftMoney = 0.25 * budjet;
                if (kategory == "VIP")
                {
                    if (leftMoney >= neededMoneyVip)
                    {
                        var moneyLeft = leftMoney - neededMoneyVip;
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else if (leftMoney < neededMoneyVip)
                    {
                        var moneyLeft = neededMoneyVip - leftMoney;
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
                else
                {
                    if (leftMoney >= neededMoneyNormal)
                    {
                        var moneyLeft = leftMoney - neededMoneyNormal;
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else if (leftMoney < neededMoneyNormal)
                    {
                        var moneyLeft = neededMoneyNormal - leftMoney;
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
            }
            else if (people > 4 && people <= 9)
            {
                var leftMoney = 0.40 * budjet;
                if (kategory == "VIP")
                {
                    if (leftMoney >= neededMoneyVip)
                    {
                        var moneyLeft = leftMoney - neededMoneyVip;
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else if (leftMoney < neededMoneyVip)
                    {
                        var moneyLeft = neededMoneyVip - leftMoney;
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
                else
                {
                    if (leftMoney >= neededMoneyNormal)
                    {
                        var moneyLeft = leftMoney - neededMoneyNormal;
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else if (leftMoney < neededMoneyNormal)
                    {
                        var moneyLeft = neededMoneyNormal - leftMoney;
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }
                }
            }
            else if (people > 9 && people <= 24)
            {
                var leftMoney = 0.50 * budjet;
                if (kategory == "VIP")
                    if (leftMoney >= neededMoneyVip)
                    {
                        var moneyLeft = leftMoney - neededMoneyVip;
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else if (leftMoney < neededMoneyVip)
                    {
                        var moneyLeft = neededMoneyVip - leftMoney;
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }

                    else
                    {
                        if (leftMoney >= neededMoneyNormal)
                        {
                            var moneyLeft = leftMoney - neededMoneyNormal;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else if (leftMoney < neededMoneyNormal)
                        {
                            var moneyLeft = neededMoneyNormal - leftMoney;
                            Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                        }
                    }
            }
        
            else if (people > 24 && people <= 49)
            {
                var leftMoney = 0.60 * budjet;
                if (kategory == "VIP")
                    if (leftMoney >= neededMoneyVip)
                    {
                        var moneyLeft = leftMoney - neededMoneyVip;
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else if (leftMoney < neededMoneyVip)
                    {
                        var moneyLeft = neededMoneyVip - leftMoney;
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }

                    else
                    {
                        if (leftMoney >= neededMoneyNormal)
                        {
                            var moneyLeft = leftMoney - neededMoneyNormal;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else if (leftMoney < neededMoneyNormal)
                        {
                            var moneyLeft = neededMoneyNormal - leftMoney;
                            Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                        }
                    }
            }
            else
            {
                var leftMoney = 0.75 * budjet;
                if (kategory == "VIP")
                    if (leftMoney >= neededMoneyVip)
                    {
                        var moneyLeft = leftMoney - neededMoneyVip;
                        Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                    }
                    else if (leftMoney < neededMoneyVip)
                    {
                        var moneyLeft = neededMoneyVip - leftMoney;
                        Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                    }

                    else
                    {
                        if (leftMoney >= neededMoneyNormal)
                        {
                            var moneyLeft = leftMoney - neededMoneyNormal;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else if (leftMoney < neededMoneyNormal)
                        {
                            var moneyLeft = neededMoneyNormal - leftMoney;
                            Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
                        }
                    }
            }



        }
    }
}
