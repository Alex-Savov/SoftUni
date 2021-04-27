using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagArr = ReadJaggedArray(rows);

            string inputCommand = Console.ReadLine();

            while (inputCommand != "END")
            {
                string[] tokensComand = inputCommand
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = tokensComand[0];
                int row = int.Parse(tokensComand[1]);
                int col = int.Parse(tokensComand[2]);
                int value = int.Parse(tokensComand[3]);

                bool isCoordinatesValid =
                    (row >= 0 && row < jagArr.Length)
                    && (col >= 0 && col < jagArr[row].Length);

                if (isCoordinatesValid)
                {
                    switch (command)
                    {
                        case "Add":
                            jagArr[row][col] += value;
                            break;
                        case "Subtract":
                            jagArr[row][col] -= value;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                inputCommand = Console.ReadLine();
            }

            foreach (var arr in jagArr)
            {
                Console.WriteLine(string.Join(' ', arr));
            }
        }
        static int[][] ReadJaggedArray(int rowMax)
        {

            int[][] jagArr = new int[rowMax][];

            for (int row = 0; row < rowMax; row++)
            {
                int[] arrElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                jagArr[row] = new int[arrElements.Length];

                for (int col = 0; col < arrElements.Length; col++)
                {
                    jagArr[row][col] = arrElements[col];
                }
            }

            return jagArr;
        }
    }
}
