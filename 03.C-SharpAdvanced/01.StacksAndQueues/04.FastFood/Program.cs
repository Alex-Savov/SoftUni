using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAvailable = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {

                if (queue.Peek() > foodAvailable)
                {
                    break;
                }

                foodAvailable -= queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
            }
        }
    }
}
