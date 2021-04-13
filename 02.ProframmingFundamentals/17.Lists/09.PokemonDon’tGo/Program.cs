using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            // take the input 
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            // initiate variable sum for the sum of removed elements
            int sum = 0;

            // create while loop until the coolection count is zero
            while (numbers.Count > 0)
            {
                // take the index
                int index = int.Parse(Console.ReadLine());
                int elementValue = 0;

                // check if the index is in range
                bool isindexInRange = true;

                if (index < 0)
                {
                    elementValue = numbers.First();
                    numbers[0] = numbers.Last();
                    isindexInRange = false;
                }
                else if (index >= numbers.Count)
                {
                    elementValue = numbers.Last();
                    numbers[numbers.Count - 1] = numbers.First();
                    isindexInRange = false;
                }
                else
                {
                    elementValue = numbers[index];
                }

                // add the index value to the sum of removed elements
                sum += elementValue;

                // initiate for loop for increasing/decreasing value of elements
                for (int i = 0; i < numbers.Count; i++)
                {
                    // increase / decrease elements
                    if (numbers[i] <= elementValue)
                    {
                        numbers[i] += elementValue;
                    }
                    else
                    {
                        numbers[i] -= elementValue;
                    }
                }

                // remove element at index
                if (isindexInRange)
                {
                    numbers.RemoveAt(index);
                }
            }
            // print the sum of the removed elements
            Console.WriteLine(sum);
        }
    }
}
