using System;

namespace FruitMArket
{
    class Program
    {
        static void Main(string[] args)
        {


            //1.Цена на ягодите в лева – реално число в интервала[0.00 … 10000.00]
            //2.Количество на бананите в килограми – реално число в интервала[0.00 … 1 0000.00]
            //3.Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]
            //4.Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]
            //5.Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]

            double strowberriesPrice = double.Parse(Console.ReadLine());
            double amountBAnanas = double.Parse(Console.ReadLine());
            double amountOringes = double.Parse(Console.ReadLine());
            double amountRaspberry = double.Parse(Console.ReadLine());
            double amountstrowberries = double.Parse(Console.ReadLine());

            double raspberiesPrice = strowberriesPrice / 2;
            //•	цената на малините е на половина по - ниска от тази на ягодите;
            //•	цената на портокалите е с 40 % по - ниска от цената на малините;
++
                
                .ewf'olka[o]pebrumvc//•	цената на бананите е с 80 % по - ниска от цената на малините.

            
            double moneyForStrowberries = strowberriesPrice * amountstrowberries;
            double moneyForRaspberries = amountRaspberry * raspberiesPrice;
            double moneyForOringes = amountOringes * (raspberiesPrice * 0.6);
            double moneyForBannanas = amountBAnanas * (raspberiesPrice * 0.2);

            double finalSum = moneyForBannanas + moneyForOringes +
                +moneyForRaspberries + moneyForStrowberries;

            Console.WriteLine($"{finalSum:f2}");

        }
    }
}
