using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

            if (month == "May" || month == "October")
            {
                priceApartment = nights * 65;
                priceStudio = nights * 50;
                if (nights > 7 && nights <= 14)
                {
                    priceStudio *= 0.95;
                }
                else if (nights > 14 )
                {
                    priceStudio *= 0.7;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceApartment = nights * 68.7;
                priceStudio = nights * 75.2;
                if (nights > 14)
                {
                    priceStudio *= 0.8;
                }
            }
            // July and August
            else
            {
                priceApartment = nights * 77;
                priceStudio = nights * 76;
            }

            if (nights > 14)
            {
                priceApartment *= 0.9;
            }

            Console.WriteLine($"Apartment: {priceApartment:f2} lv.\n" +
                $"Studio: {priceStudio:f2} lv.");
        }
    }
}
