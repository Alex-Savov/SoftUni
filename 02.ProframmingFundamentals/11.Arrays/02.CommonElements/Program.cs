using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secLine = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            if (firstLine.Length < secLine.Length)
            {
                for (int i = 0; i < firstLine.Length; i++)
                {
                    for (int j = 0; j < secLine.Length; j++)
                    {
                        if (firstLine[i] == secLine[j])
                        {
                            Console.Write($"{secLine[j]} ");
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < secLine.Length; i++)
                {
                    for (int j = 0; j < firstLine.Length; j++)
                    {
                        if (secLine[i] == firstLine[j])
                        {
                            Console.Write($"{firstLine[j]} ");
                        }
                    }
                }
            }
        }
    }
}
