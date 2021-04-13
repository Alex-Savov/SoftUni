using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfVisitors = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double priceTicket = 0;

            if (dayOfWeek == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    priceTicket = 8.45;
                }
                else if (typeOfGroup == "Business")
                {
                    priceTicket = 10.9;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceTicket = 15;
                }

              
            }
            else if (dayOfWeek == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    priceTicket = 9.8;
                }
                else if (typeOfGroup == "Business")
                {
                    priceTicket = 15.6;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceTicket = 20;
                }

               
            }
            else if (dayOfWeek == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    priceTicket = 10.46;
                }
                else if (typeOfGroup == "Business")
                {
                    priceTicket = 16;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceTicket = 22.5;
                }

               
            }

            if (numberOfVisitors >= 30 && typeOfGroup == "Students")
            {
                priceTicket *= 0.85;
            }
            else if (numberOfVisitors >= 100 && typeOfGroup == "Business")
            {
                numberOfVisitors -= 10;
            }
            else if (numberOfVisitors >= 10 && numberOfVisitors <= 20
                && typeOfGroup == "Regular")
            {
                priceTicket *= 0.95;
            }

            double totalPrice = priceTicket * numberOfVisitors;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
