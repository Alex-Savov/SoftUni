using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            double boatPrice = 0;

            if (season == "Spring")
            {
                boatPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatPrice = 4200;
            }
            else
            // season == "Winter"
            {
                boatPrice = 2600;
            }

            if (fishermans <= 6)
            {
                boatPrice *= 0.9;
            }
            else if (fishermans <= 11)
            {
                boatPrice *= 0.85;
            }
            else
            {
                boatPrice *= 0.75;
            }

            if (fishermans % 2 == 0 && season != "Autumn")
            {
                boatPrice *= 0.95;
            }

            double moneyDiff = Math.Abs(budget - boatPrice);
            if (budget < boatPrice)
            {
                Console.WriteLine($"Not enough money! You need {moneyDiff:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {moneyDiff:f2} leva left.");
            }
        }
    }
}
