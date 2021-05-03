using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guestList = new HashSet<string>();

            string inputList = Console.ReadLine();

            while (inputList != "PARTY")
            {
                guestList.Add(inputList);
                inputList = Console.ReadLine();
            }

            string guest = Console.ReadLine();

            while (guest != "END")
            {

                if (guestList.Count == 0)
                {
                    break;
                }

                if (guestList.Contains(guest))
                {
                    guestList.Remove(guest);
                }

                guest = Console.ReadLine();
            }

            Console.WriteLine(guestList.Count);

            if (guestList.Count > 0)
            {
                if (guestList.Any(x => char.IsDigit(x.First())))
                {
                    foreach (var item in guestList.Where(x => char.IsDigit(x.First())))
                    {
                        Console.WriteLine(item);
                    }
                }

                foreach (var item in guestList.Where(x => char.IsLetter(x.First())))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
