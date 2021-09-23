using System;

namespace _04.PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string pizzaName = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                Pizza pizza = new Pizza(pizzaName);

                while (true)
                {
                    string[] lineInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (lineInput[0] == "END")
                    {
                        break;
                    }
                    string command = lineInput[0];
                    string type = lineInput[1];

                    if (command.ToLower() == "dough")
                    {
                        string technique = lineInput[2];
                        double weight = double.Parse(lineInput[3]);

                        pizza.Dough = new Dough(type, technique, weight);
                    }
                    else if (command.ToLower() == "topping")
                    {
                        double weight = double.Parse(lineInput[2]);

                        pizza.AddTopping(new Toppring(type, weight));
                    }
                }

                Console.WriteLine(pizza); ;
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine(aex.Message);
            }
        }
    }
}
