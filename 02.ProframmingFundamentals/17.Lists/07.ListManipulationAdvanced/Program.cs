using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> initial = new List<int>(numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                initial.Add(numbers[i]);
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commArgs[0];

                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commArgs[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRmove = int.Parse(commArgs[1]);
                        numbers.Remove(numberToRmove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(commArgs[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commArgs[1]);
                        int indexToInsert = int.Parse(commArgs[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Contains":
                        int number = int.Parse(commArgs[1]);
                        Console.WriteLine(numbers.Contains(number) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(' ', numbers.Where(x => x % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(' ', numbers.Where(x => x % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string conditionalOperator = commArgs[1];
                        int filterNumber = int.Parse(commArgs[2]);
                        PrintFiltered(numbers, conditionalOperator, filterNumber);
                        break;
                }

                command = Console.ReadLine();
            }

            bool isChanged = initial.SequenceEqual(numbers);

            if (!isChanged)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }

        static void PrintFiltered (List<int> collection, string conditionalOperator, int number)
        {
            switch (conditionalOperator)
            {
                case "<":
                    Console.WriteLine(string.Join(' ', collection.Where(x => x < number)));
                    break;
                case ">":
                    Console.WriteLine(string.Join(' ', collection.Where(x => x > number)));
                    break;
                case "<=":
                    Console.WriteLine(string.Join(' ', collection.Where(x => x <= number)));
                    break;
                case ">=":
                    Console.WriteLine(string.Join(' ', collection.Where(x => x >= number)));
                    break;
                default:
                    break;
            }
        }
    }
}
