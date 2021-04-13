using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double totalMoneySpent = 0.0;
            string gameName = Console.ReadLine();
            bool isOutOfMoney = false;

            while (gameName != "Game Time")
            {
                double gamePrice = 0;
                bool isFound = true;

                switch (gameName)
                {
                    case "OutFall 4": gamePrice = 39.99;  break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    default:
                        isFound = false;
                        Console.WriteLine("Not Found");
                        break;
                }

                if (currentBalance < gamePrice && isFound)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (isFound)
                {
                    currentBalance -= gamePrice;
                    totalMoneySpent += gamePrice;
                    Console.WriteLine($"Bought {gameName}");

                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        isOutOfMoney = true;
                        break;
                    }
                }

                gameName = Console.ReadLine();
            }

            if (!isOutOfMoney)
            {
                Console.WriteLine($"Total spent: ${totalMoneySpent:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}
