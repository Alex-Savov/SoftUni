using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingLot = new Dictionary<string, string>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];
                string userName = commandArgs[1];

                if (command == "register")
                {
                    string licensePlate = commandArgs[2];

                    if (!parkingLot.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                        parkingLot.Add(userName, licensePlate);   
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else if (command == "unregister")
                {
                    if (parkingLot.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        parkingLot.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
            }

            foreach (var user in parkingLot)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
