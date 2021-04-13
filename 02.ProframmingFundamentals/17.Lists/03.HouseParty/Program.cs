using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string guest = command[0];

                if (command.Contains("not"))
                {
                    if (guests.Contains(guest))
                    {
                        guests.Remove(guest);
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not in the list!");
                    }
                }
                else
                {
                    if (!guests.Contains(guest))
                    {
                        guests.Add(guest);
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is already in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(" \n", guests));
        }
    }
}
