using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degreese = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (partOfDay == "Morning")
            {
                if (degreese >= 10 && degreese <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degreese > 18 && degreese <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                //degreese > 25
                else
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (partOfDay == "Afternoon")
            {
                if (degreese >= 10 && degreese <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degreese > 18 && degreese <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                //degreese > 25
                else
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            // partOfDay == "Evening"
            else
            {
                if (degreese >= 10 && degreese <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degreese > 18 && degreese <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                //degreese > 25
                else
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degreese} degrees, get your {outfit} and {shoes}.");
        }
    }
}
