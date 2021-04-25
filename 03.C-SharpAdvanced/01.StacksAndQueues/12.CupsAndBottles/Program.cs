using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> bottles = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int wastedWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currentCup = cups.Peek();

                if (bottles.Peek() <= currentCup)
                {
                    while (currentCup > 0 && bottles.Count > 0)
                    {
                        currentCup -= bottles.Pop();

                        if (currentCup < 0)
                        {
                            wastedWater += Math.Abs(currentCup);
                        }
                    }

                    cups.Dequeue();
                }
                else
                {
                    cups.Dequeue();
                    wastedWater += bottles.Pop() - currentCup;
                }
            }

            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
            }

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(' ', cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
