using System;
using System.Collections.Generic;

namespace _04.Orders
{
    //1.create class PriceAndQuantity

    class PriceAndQuntity
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotlalPrice
        {
            get
            {
                return Quantity * Price;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //2. initiate dictionary of string, PriceAndQuantity
            Dictionary<string, PriceAndQuntity> products = new Dictionary<string, PriceAndQuntity>();

            //3. get the input
            string input = Console.ReadLine();

            //4. initiate while loop untill input is "buy"
            while (input != "buy")
            {
                string[] productData =input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string product = productData[0];
                double price = double.Parse(productData[1]);
                int quantity = int.Parse(productData[2]);

                //	-check if product exists
                if (products.ContainsKey(product))
                {
                    //		>add the quantitty to its current one
                    products[product].Quantity += quantity;

                    //		>update the price
                    products[product].Price = price;
                }
                else  //	-if not add it
                {
                    products.Add(product, new PriceAndQuntity() { Price = price, Quantity = quantity });
                }

                input = Console.ReadLine();
            }

            //5. print the products with the total price for each one
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.TotlalPrice:f2}");
            }
        }
    }
}
