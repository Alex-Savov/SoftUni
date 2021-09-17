using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BirthdayCelebration
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> guests = new Stack<int>(Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .Reverse()
                 .ToArray());

            Stack<int> plates = new Stack<int>(Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray());

            int wastedFood = 0;

            while (plates.Count != 0 && guests.Count != 0)
            {
                int currentPlate = plates.Pop();
                int currentGuest = guests.Pop();

                if (currentPlate >= currentGuest)
                {
                    wastedFood += (currentPlate - currentGuest);
                }
                else
                {
                    currentGuest -= currentPlate;
                    guests.Push(currentGuest);
                }
            }

            if (guests.Count == 0)
            {
                Console.WriteLine($"Plates: {string.Join(' ', plates)}");
            }
            else
            {
                Console.WriteLine($"Guests: {string.Join(' ', guests)}");
            }

            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
