using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> lot = new HashSet<string>();

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "END")
                {
                    break;
                }

                string command = tokens[0];
                string regNumber = tokens[1];

                switch (command)
                {
                    case "IN":
                        lot.Add(regNumber);
                        break;
                    case "OUT":
                        lot.Remove(regNumber);
                        break;
                }
            }

            if (lot.Count > 0)
            {
                foreach (var car in lot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
