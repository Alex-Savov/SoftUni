using System;

namespace PlantingBAckyards
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareAree = double.Parse(Console.ReadLine());

            double price = squareAree * 7.61;
            double finalPrice = price * 0.82;
            double discount = price - finalPrice;

            Console.WriteLine($"The final price is: {finalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
