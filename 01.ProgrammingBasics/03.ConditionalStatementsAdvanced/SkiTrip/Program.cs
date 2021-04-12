using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string evaluation = Console.ReadLine();

            int nights = days - 1;
            double price = 0;

            if (roomType == "room for one person")
            {
                price = nights * 18;
            }
            else if (roomType == "apartment")
            {
                price = nights * 25;
                if (days < 10)
                {
                    price *= 0.7;
                }
                else if (days <= 15)
                {
                    price *= 0.65;
                }
                else // days > 15
                {
                    price *= 0.5;
                }
            }
            else // president apartment
            {
                price = nights * 35;
                if (days < 10)
                {
                    price *= 0.9;
                }
                else if (days <= 15)
                {
                    price *= 0.85;
                }
                else // days > 15
                {
                    price *= 0.8;
                }
            }

            if (evaluation == "positive")
            {
                price *= 1.25;
            }
            else
            {
                price *= 0.9;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
