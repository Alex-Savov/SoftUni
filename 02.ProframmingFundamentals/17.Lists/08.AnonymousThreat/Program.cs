using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            // take the input

            List<string> inputLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            // take the command line

            string command = Console.ReadLine();

            // initiate while loop until "3:1" is recieved

            while (command != "3:1")
            {
                string[] commandArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];
                int index = int.Parse(commandArgs[1]);

                if (action == "merge")
                {
                    int endIndex = int.Parse(commandArgs[2]);

                    if (index < 0)
                    {
                        index = 0;
                    }

                    if (endIndex >= inputLine.Count)
                    {
                        endIndex = inputLine.Count - 1;
                    }

                    inputLine = MergeElements(inputLine, index, endIndex);
                }
                else if (action == "divide")
                {
                    int partitions = int.Parse(commandArgs[2]);
                    inputLine = DivideElement(inputLine, index, partitions);
                }
               
                command = Console.ReadLine();
            }

            // print the final collection separated bu space

            Console.WriteLine(string.Join(' ', inputLine));
        }

        // create a method for "divide" command
        private static List<string> DivideElement(List<string> inputLine, int index, int partitions)
        {
            string element = inputLine[index];
            int elementCount = 0;

            if ((element.Length / partitions) == 0)
            {
                return inputLine;
            }

            int partitionLenght = element.Length / partitions;
            int remaining = element.Length % partitions;

            for (int i = 1; i <= partitions; i++)
            {
                StringBuilder partition = new StringBuilder();

                for (int j = 0; j < partitionLenght; j++)
                {
                    partition.Append(element[elementCount]);
                    elementCount++;
                }

                inputLine.Insert(index + i, partition.ToString());

                if (i == partitions && remaining != 0)
                {
                    int start = element.Length - remaining;

                    for (int k = start; k < element.Length; k++)
                    {
                        inputLine[index + i] += element[k];
                    }
                }
            }

            inputLine.RemoveAt(index);
            return inputLine;
        }

        // create a method for "merge" command
        private static List<string> MergeElements(List<string> inputLine, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                inputLine[startIndex] += inputLine[startIndex + 1];
                inputLine.RemoveAt(startIndex + 1);
            }

            return inputLine;
        }
    }
}
