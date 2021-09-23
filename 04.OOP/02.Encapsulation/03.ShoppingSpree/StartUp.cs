using System;
using System.Collections.Generic;

namespace _03.ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            try
            {
                people = ReadPeople();
                products = ReadProducts();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            while (true)
            {
                string lineInput = Console.ReadLine();

                if (lineInput == "END")
                {
                    break;
                }

                string[] tokensCommand = lineInput
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string personName = tokensCommand[0];
                string productName = tokensCommand[1];

                try
                {
                    people[personName].AddProduct(products[productName]);
                    Console.WriteLine($"{personName} bought {productName}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            foreach (var person in people.Values)
            {
                Console.WriteLine(person);
            }
        }
        public static Dictionary<string, Product> ReadProducts()

        {
            Dictionary<string, Product> result = new Dictionary<string, Product>();

            string[] tokens = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                string[] personInfo = token.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                decimal cost = decimal.Parse(personInfo[1]);

                result.Add(name, new Product(name, cost));
            }

            return result;
        }
        public static Dictionary<string, Person> ReadPeople()
        {
            Dictionary<string, Person> result = new Dictionary<string, Person>();

            string[] tokens = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                string[] personInfo = token.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);

                result.Add(name, new Person(name, money));
            }

            return result;
        }
    }
}
