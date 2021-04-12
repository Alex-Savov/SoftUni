using System;

namespace GodzilaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double statOutfit = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double priceOutfit = statOutfit * statists;

            if (statists > 150)
            {
                priceOutfit *= 0.9;
            }
            double expences = decor + priceOutfit;
            double moneyLeft = Math.Abs(budget - (decor + priceOutfit));

            if (budget < expences)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyLeft:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
