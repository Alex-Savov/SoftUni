using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commArgs[0] == "Add")
                {
                    int wagon = int.Parse(commArgs[1]);
                    train.Add(wagon);
                }
                else
                {
                    int passengers = int.Parse(commArgs[0]);
                    train = AddPassengers(train, maxCapacity, passengers);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', train));
        }

        private static List<int> AddPassengers (List<int> list, int wagonCapacity, int passangersToFit)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] + passangersToFit <= wagonCapacity)
                {
                    list[i] += passangersToFit;
                    break;
                }
            }

            return list;
        }
    }
}
