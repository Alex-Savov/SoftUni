using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue($"{Console.ReadLine()} {i}");
            }

            int remainingFuel = 0;
            for (int i = 0; i < queue.Count; i++)
            {
                int[] pumpData = queue.Peek()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int fuelAmount = pumpData[0];
                int distance = pumpData[1];
                fuelAmount += remainingFuel;

                if (fuelAmount >= distance)
                {
                    remainingFuel = (fuelAmount - distance);
                }
                else
                {
                    remainingFuel = 0;
                    i = -1;
                }

                queue.Enqueue(queue.Dequeue());
            }

            string index = queue
                .Dequeue()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray()
                .Last();

            Console.WriteLine(index);
        }
    }
}
