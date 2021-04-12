using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]

            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyB = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double pricePuzz = puzzles * 2.6;
            double priceDolls = dolls * 3;
            double priceBear = teddyB * 4.1;
            double priceMin = minions * 8.2;
            double priceTr = trucks * 2;

            double sumToys = puzzles + dolls + teddyB + minions + trucks;
            double sumMoney = pricePuzz + priceDolls + priceBear + priceMin + priceTr;

            //Ако поръчаните играчки са 50 или повече магазинът прави отстъпка
            //    25 % от общата цена. От спечелените пари Петя трябва да даде 10 % 
            //    за наема на магазина.Да се пресметне дали парите ще ѝ стигнат да 
            //    отиде на екскурзия.
            if (sumToys >= 50)
            {
                sumMoney *= 0.75;
            }

            // calculating money after rent
            sumMoney *= 0.9;
            double moneyDiff = Math.Abs(sumMoney - vacationPrice);

            if (sumMoney < vacationPrice)
            { 
                Console.WriteLine($"Not enough money! {moneyDiff:f2} lv needed.");
            }
            else
            {
                Console.WriteLine($"Yes! {moneyDiff:f2} lv left.");
            }
        }
    }
}
