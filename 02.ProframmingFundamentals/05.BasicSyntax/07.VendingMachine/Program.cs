using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCoins = Console.ReadLine();
            double moneyInserted = 0;
            while (inputCoins != "Start")
            {
                double coins = double.Parse(inputCoins);
                switch (coins)
                {
                    case 2:
                        moneyInserted += coins;
                        break;
                    case 1:
                        moneyInserted += coins;
                        break;
                    case 0.5:
                        moneyInserted += coins;
                        break;
                    case 0.2:
                        moneyInserted += coins;
                        break;
                    case 0.1:
                        moneyInserted += coins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {inputCoins}");
                        break;
                }

                inputCoins = Console.ReadLine();
            }

            string product = Console.ReadLine().ToLower();

            while (product != "end")
            {
                switch (product)
                {
                    case "nuts":
                        if (moneyInserted >= 2.0)
                        {
                            Console.WriteLine($"Purchased {product}");
                            moneyInserted -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "water":
                        if (moneyInserted >= 0.7)
                        {
                            Console.WriteLine($"Purchased {product}");
                            moneyInserted -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "crisps":
                        if (moneyInserted >= 1.5)
                        {
                            Console.WriteLine($"Purchased {product}");
                            moneyInserted -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "soda":
                        if (moneyInserted >= 0.8)
                        {
                            Console.WriteLine($"Purchased {product}");
                            moneyInserted -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "coke":
                        if (moneyInserted >= 1.0)
                        {
                            Console.WriteLine($"Purchased {product}");
                            moneyInserted -= 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                product = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Change: {moneyInserted:f2}");
        }
    }
}
