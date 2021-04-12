using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string placeTostay = "";
            double moneyNeeded = 0;

            if (budget <= 100)
            {
                location = "Bulgaria";

                if (season == "summer")
                {
                    placeTostay = "Camp";
                    moneyNeeded = budget * 0.3;
                }
                else
                // season == "winter"
                {
                    placeTostay = "Hotel";
                    moneyNeeded = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                location = "Balkans";

                if (season == "summer")
                {
                    placeTostay = "Camp";
                    moneyNeeded = budget * 0.4;
                }
                else
                // season == "winter"
                {
                    placeTostay = "Hotel";
                    moneyNeeded = budget * 0.8;
                }
            }
            // budget > 1000
            else
            {
                placeTostay = "Hotel";
                location = "Europe";
                moneyNeeded = budget * 0.9;
            }

            Console.WriteLine("Somewhere in {0}\n{1} - {2:f2}", location, placeTostay, moneyNeeded);
        }
    }
}
