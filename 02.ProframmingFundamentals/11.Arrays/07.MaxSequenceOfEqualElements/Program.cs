using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int startIndexSeq = 0;
            int sequenceLeght = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currentStartIndex = 0;
                int currentSeqLenght = 0;

                if (arr[i] == arr[i +1])
                {
                    currentStartIndex = i;
                    currentSeqLenght++;
                    for (int j = i; (j < arr.Length - 1) && (arr[j] == arr[j + 1]); j++)
                    {
                        currentSeqLenght++;
                    }
                    i += currentSeqLenght - 1;
                }

                if (sequenceLeght < currentSeqLenght)
                {
                    startIndexSeq = currentStartIndex;
                    sequenceLeght = currentSeqLenght;
                }
            }

            for (int i = startIndexSeq; i < startIndexSeq + sequenceLeght; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
