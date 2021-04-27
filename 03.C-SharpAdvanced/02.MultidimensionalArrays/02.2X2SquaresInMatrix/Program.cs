using System;
using System.Linq;

namespace _02._2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxRows = dimensions[0];
            int maxCols = dimensions[1];

            string[,] matrix = ReadMatrix(new string[maxRows, maxCols]);
            int equalMatrxCount = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    bool isEqual = (matrix[row, col] == matrix[row, col + 1])
                        && (matrix[row + 1, col] == matrix[row + 1, col + 1])
                        && (matrix[row, col] == matrix[row + 1, col + 1]);

                    if (isEqual)
                    {
                        equalMatrxCount++;
                    }
                }
            }

            Console.WriteLine(equalMatrxCount);
        } 
        static string[,] ReadMatrix(string[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
