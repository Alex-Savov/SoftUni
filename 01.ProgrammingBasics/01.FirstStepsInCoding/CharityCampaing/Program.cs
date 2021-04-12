using System;

namespace CharityCampaing
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfCampaign = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());

           
            int cakes = int.Parse(Console.ReadLine());
            int waflles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double moneyFromCakes = cakes * 45;
            double moneyFromWaffles = waflles * 5.8;
            double moneyFromPancakes = pancakes * 3.2;

            double sumMoney = moneyFromCakes + moneyFromPancakes + moneyFromWaffles;
            double moneyPerCampaign = sumMoney * cooks * daysOfCampaign;

            double finalSum = moneyPerCampaign *= 0.875;

            Console.WriteLine(finalSum);

        }
    }
}
