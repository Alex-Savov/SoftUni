using System;

namespace ToyShop2
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            string convertFrom = Console.ReadLine();
            string convertTo = Console.ReadLine();

            if (convertFrom == "m" && convertTo == "cm")
            {
                lenght *= 100;
            }
            else if (convertFrom == "m" && convertTo == "mm")
            {
                lenght *= 1000;
            }
            else if (convertFrom == "cm" && convertTo == "m")
            {
                lenght /= 100;
            }
            else if (convertFrom == "cm" && convertTo == "mm")
            {
                lenght *= 10;
            }
            else if (convertFrom == "mm" && convertTo == "m")
            {
                lenght /= 1000;
            }
            else if (convertFrom == "mm" && convertTo == "cm")
            {
                lenght /= 10;
            }

            Console.WriteLine($"{lenght:f3}");
        }
    }
}