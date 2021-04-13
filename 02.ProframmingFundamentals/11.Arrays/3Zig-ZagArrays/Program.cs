using System;
using System.Linq;

namespace _3Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = input[0];
                    secondArr[i] = input[1];
                }
                else
                {
                    firstArr[i] = input[1];
                    secondArr[i] = input[0];
                }
            }

            Console.WriteLine("{0}\n{1}", 
                string.Join(' ', firstArr),
                string.Join(' ', secondArr));
        }
    }
}
