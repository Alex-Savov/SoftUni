using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture_2
{
    class Furniture
    {
        public string Type { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-Za-z]+)<<(\d+\.?\d*)!(\d+)";
            Regex regx = new Regex(pattern);
            string input = Console.ReadLine();
            List<Furniture> purchases = new List<Furniture>();

            while (input != "Purchase")
            {
                Match match = regx.Match(input);

                if (match.Success)
                {
                    string type = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);

                    purchases.Add(new Furniture
                    {
                        Type = type,
                        Price = price,
                        Quantity = quantity
                    });
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            double totalPrice = 0.0;

            foreach (var purchase in purchases)
            {
                totalPrice += purchase.TotalPrice;
                Console.WriteLine(purchase.Type);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
