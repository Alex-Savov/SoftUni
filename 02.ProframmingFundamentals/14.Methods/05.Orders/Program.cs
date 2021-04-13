using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double total = TotalOrderCalcilator(product, quantity);
            Console.WriteLine("{0:f2}", total);
        }

        static double TotalOrderCalcilator(string item, int quantity)
        {
            double total = 0.0;
            switch (item)
            {
                case "coffee":
                    total = quantity * 1.5;
                    break;
                case "water":
                    total = quantity * 1.0;
                    break;
                case "coke":
                    total = quantity * 1.4;
                    break;
                case "snacks":
                    total = quantity * 2.0;
                    break;
                default:
                    break;
            }

            return total;
        }
    }
}
