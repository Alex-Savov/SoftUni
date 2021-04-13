using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
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
            //1 make the regex
            string pattern = @">>([A-Za-z]+)<<(\d+\.?\d*)!(\d+)";
            Regex regx = new Regex(pattern);

            //2 get the input
            string input = Console.ReadLine();
            List<Furniture> allPurchases = new List<Furniture>();

            while (input != "Purchase")
            {
                //3 validate the input
                bool isValid = regx.IsMatch(input);

                if (isValid)
                {
                    //4 split the input
                    string[] separators = { ">>", "<<", "!" };
                    string[] data = input
                        .Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    string furniture = data[0];
                    double price = double.Parse(data[1]);
                    int quantity = int.Parse(data[2]);

                    //5 store the data
                    allPurchases.Add(new Furniture
                    {
                        Type = furniture,
                        Price = price,
                        Quantity = quantity
                    });
                }

                input = Console.ReadLine();
            }

            //6 ptint the data
            double totalPrice = 0.0;
            Console.WriteLine("Bought furniture:");

            foreach (var purchase in allPurchases)
            {
                totalPrice += purchase.TotalPrice;
                Console.WriteLine(purchase.Type);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
