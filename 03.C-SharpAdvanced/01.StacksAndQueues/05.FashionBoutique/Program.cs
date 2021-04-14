using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int rackCapacity = int.Parse(Console.ReadLine());
            int usedRacks = 0;
            int itemValueSum = 0;

            while (stack.Count > 0)
            {
                if ((stack.Peek() + itemValueSum) > rackCapacity)
                {
                    usedRacks++;
                    itemValueSum = 0;
                    continue;
                }

                itemValueSum += stack.Pop();
            }

            if (itemValueSum > 0)
            {
                usedRacks++;
            }

            Console.WriteLine(usedRacks);
        }
    }
}
