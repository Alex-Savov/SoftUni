using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] actionCount = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numbersToPush = actionCount[0];
            int numbersToPop = actionCount[1];
            int numbersToLook = actionCount[2];

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbersToPush; i++)
            {
                if (i == numbers.Length)
                {
                    break;
                }

                stack.Push(numbers[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                if (stack.Count == 0)
                {
                    break;
                }

                stack.Pop();
            }

            bool isContains = false;
            int minNum = int.MaxValue;

            while (stack.Count > 0)
            {
                int pop = stack.Pop();
                if (pop == numbersToLook)
                {
                    isContains = true;
                    break;
                }
                else
                {
                    if (minNum > pop)
                    {
                        minNum = pop;
                    }
                }
            }

            if (minNum == int.MaxValue)
            {
                minNum = 0;
            }

            Console.WriteLine(isContains ? "true" : minNum.ToString());
        }
    }
}
