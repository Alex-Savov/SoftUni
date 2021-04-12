using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double productPrice = 0;

            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        productPrice = 0.5;
                        break;
                    case "water":
                        productPrice = 0.8;
                        break;
                    case "beer":
                        productPrice = 1.20;
                        break;
                    case "sweets":
                        productPrice = 1.45;
                        break;
                    case "peanuts":
                        productPrice = 1.60;
                        break;
                    default:
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        productPrice = 0.40;
                        break;
                    case "water":
                        productPrice = 0.70;
                        break;
                    case "beer":
                        productPrice = 1.15;
                        break;
                    case "sweets":
                        productPrice = 1.30;
                        break;
                    case "peanuts":
                        productPrice = 1.50;
                        break;
                    default:
                        break;
                }
            }
            else // city == Varna
            {
                switch (product)
                {
                    case "coffee":
                        productPrice = 0.45;
                        break;
                    case "water":
                        productPrice = 0.70;
                        break;
                    case "beer":
                        productPrice = 1.10;
                        break;
                    case "sweets":
                        productPrice = 1.35;
                        break;
                    case "peanuts":
                        productPrice = 1.55;
                        break;
                    default:
                        break;
                }
            }
            double output = quantity * productPrice;
            Console.WriteLine(output);
        }
    }
}
