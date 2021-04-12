using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Дължина в см – цяло число в интервала[10 … 500]
            //2.Широчина в см – цяло число в интервала[10 … 300]
            //3.Височина в см – цяло число в интервала[10… 200]
            //4.Процент  – реално число в интервала[0.000 … 100.000]

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double percentUtilized = double.Parse(Console.ReadLine());

            double tankVolume = length * width * heigth * 0.001;
            double waterVolume = tankVolume - (tankVolume * percentUtilized / 100);

            Console.WriteLine(waterVolume);

        }
    }
}
