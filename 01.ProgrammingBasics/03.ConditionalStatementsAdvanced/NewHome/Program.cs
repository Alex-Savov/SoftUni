using System;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int amountflowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double flowersPrice = 0;

            if (flowersType == "Roses")
            {
                flowersPrice = amountflowers * 5;
                if (amountflowers > 80)
                {
                    flowersPrice *= 0.9;
                }
            }
            else if (flowersType == "Dahlias")
            {
                flowersPrice = amountflowers * 3.8;
                if (amountflowers > 90)
                {
                    flowersPrice *= 0.85;
                }
            }
            else if (flowersType == "Tulips")
            {
                flowersPrice = amountflowers * 2.8;
                if (amountflowers > 80)
                {
                    flowersPrice *= 0.85;
                }
            }
            else if (flowersType == "Narcissus")
            {
                flowersPrice = amountflowers * 3;
                if (amountflowers < 120)
                {
                    flowersPrice *= 1.15;
                }
            }
            // flowersType == "Gladiolus"
            else
            {
                flowersPrice = amountflowers * 2.5;
                if (amountflowers < 80)
                {
                    flowersPrice *= 1.2;
                }
            }

            double moneyDiff = Math.Abs(budget - flowersPrice);

            if (budget < flowersPrice)
            {
                Console.WriteLine($"Not enough money, you need {moneyDiff:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {amountflowers} {flowersType} and {moneyDiff:f2} leva left.");
            }
        }
    }
}
