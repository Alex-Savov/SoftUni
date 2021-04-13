using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Add {number} – add number at the end.
            //•	Insert {number} {index} – insert number at given index.
            //•	Remove {index} – remove at index.
            //•	Shift left {count} – first number becomes last ‘count’ times.
            //•	Shift right {count} – last number becomes first ‘count’ times.

            //Note: there is a possibility that the given index is outside of 
            //the bounds of the array. In that case print "Invalid index"

            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commArgs[0];

                if (action == "Add")
                {
                    int number = int.Parse(commArgs[1]);
                    numbers.Add(number);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(commArgs[1]);
                    int index = int.Parse(commArgs[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                        
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(commArgs[1]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "Shift")
                {
                    string directon = commArgs[1];
                    int count = int.Parse(commArgs[2]);

                    switch (directon)
                    {
                        case "left":
                            numbers = RotateLeft(numbers, count);
                            break;
                        case "right":
                            numbers = RotateRight(numbers, count);
                            break;
                        default:
                            break;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }

        private static List<int> RotateRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int temp = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, temp);
            }

            return numbers;
        }

        private static List<int> RotateLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int temp = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(temp);
            }

            return numbers;
        }
    }
}
