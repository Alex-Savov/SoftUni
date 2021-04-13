using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] initialIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            // chek if initial indexes are in range and load the field

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                if (initialIndexes[i] >= 0 && initialIndexes[i] < field.Length)
                {
                    field[initialIndexes[i]] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end" && field.Sum() != 0)
            {
                string[] commArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int bugIndex = int.Parse(commArgs[0]);
                string direction = commArgs[1];
                int flightLength = int.Parse(commArgs[2]);
                int currentFlightLenght = flightLength; 

                // chek if indexes from the command are in range

                if ((bugIndex < 0 || bugIndex > field.Length - 1)
                    || (field[bugIndex] == 0) 
                    || (flightLength == 0))
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (direction == "right")
                {
                    while (true)
                    {
                        int landingIndex = bugIndex + currentFlightLenght;
                        if (landingIndex < field.Length && field[landingIndex] == 0)
                        {
                            field[bugIndex] = 0;
                            field[landingIndex] = 1;
                            break;
                        }
                        else if (landingIndex < field.Length && field[landingIndex] == 1)
                        {
                            currentFlightLenght += flightLength;
                        }
                        else if (landingIndex >= field.Length)
                        {
                            field[bugIndex] = 0;
                            break;
                        }
                    }
                }
                else // going to the left
                {
                    while (true)
                    {
                        int landingIndex = bugIndex - currentFlightLenght;
                        if (landingIndex >= 0 && field[landingIndex] == 0)
                        {
                            field[bugIndex] = 0;
                            field[landingIndex] = 1;
                            break;
                        }
                        else if (landingIndex >= 0 && field[landingIndex] == 1)
                        {
                            currentFlightLenght += flightLength;
                        }
                        else if (landingIndex < 0)
                        {
                            field[bugIndex] = 0;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', field));
        }
    }
}
