using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double moneyNeeded = double.Parse(Console.ReadLine());
                double moneySaved = 0;

                while (moneyNeeded > moneySaved)
                {
                    double money = double.Parse(Console.ReadLine());
                    moneySaved += money;
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
