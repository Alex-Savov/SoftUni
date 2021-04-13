using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commArgs[0];

                if (action == "Add")
                {
                    int number = int.Parse(commArgs[1]);
                    numbers.Add(number);
                }
                else if (action == "Remove")
                {
                    int number = int.Parse(commArgs[1]);
                    numbers.Remove(number);
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(commArgs[1]);
                    numbers.RemoveAt(index);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(commArgs[1]);
                    int index = int.Parse(commArgs[2]);
                    numbers.Insert(index, number);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
