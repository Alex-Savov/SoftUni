﻿using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            bool fail = true;
            double price = 0;

            switch (day)
            {
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.70;
                            break;
                        case "apple":
                            price = 1.25;
                            break;
                        case "orange":
                            price = 0.90;
                            break;
                        case "grapefruit":
                            price = 1.60;
                            break;
                        case "kiwi":
                            price = 3.00;
                            break;
                        case "pineapple":
                            price = 5.60;
                            break;
                        case "grapes":
                            price = 4.20;
                            break;
                        default:
                            fail = false;
                            break;
                    }

                    break;
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.5;
                            break;
                        case "apple":
                            price = 1.20;
                            break;
                        case "orange":
                            price = 0.85;
                            break;
                        case "grapefruit":
                            price = 1.45;
                            break;
                        case "kiwi":
                            price = 2.70;
                            break;
                        case "pineapple":
                            price = 5.50;
                            break;
                        case "grapes":
                            price = 3.85;
                            break;
                        default:
                            fail = false;
                            break;
                    }

                    break;
                default:
                    fail = false;
                    break;
            }
            if (fail)
            {
                double output = amount * price;
                Console.WriteLine($"{output:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
