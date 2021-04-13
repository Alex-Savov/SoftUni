using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtDNA = int.Parse(Console.ReadLine());

            int[] bestDNA = new int[lenghtDNA];
            int startIndex = 0;
            int lenghtSeqence = 0;
            int sampleCounter = 0;
            int bestSamble = 0;

            string sequence = Console.ReadLine();
            while (sequence != "Clone them!")
            {
                sampleCounter++;

                int[] currentSeq = sequence
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currentIndex = 0;
                int currentLenght = 0;

                for (int i = 0; i < currentSeq.Length-1; i++)
                {
                    if ((currentSeq[i] == 1) && (currentSeq[i] == currentSeq[i + 1]))
                    {
                        currentIndex = i;
                        currentLenght++;

                        for (int j = i; (j < currentSeq.Length - 1)
                            && (currentSeq[j] == currentSeq[j + 1]); j++)
                        {
                            currentLenght++;
                        }
                        i += currentLenght - 1;
                    }
                }

                if ((lenghtSeqence < currentLenght)
                    || (startIndex > currentIndex)
                    || (bestDNA.Sum() < currentSeq.Sum()))
                {
                    lenghtSeqence = currentLenght;
                    startIndex = currentIndex;
                    bestDNA = currentSeq;
                    bestSamble = sampleCounter;
                }

                sequence = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSamble} with sum: {bestDNA.Sum()}.");
            Console.WriteLine(string.Join(' ',bestDNA));
        }
    }
}
