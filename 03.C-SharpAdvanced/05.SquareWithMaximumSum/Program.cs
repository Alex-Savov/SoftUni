using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = ReadMatrix(matrixSize[0], matrixSize[1]);

            int maxSum = int.MinValue;
            int rowMax = 0;
            int colMax = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col]
                                    + matrix[row, col + 1]
                                    + matrix[row + 1, col]
                                    + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rowMax = row;
                        colMax = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[rowMax, colMax]} {matrix[rowMax, colMax + 1]}");
            Console.WriteLine($"{matrix[rowMax + 1, colMax]} {matrix[rowMax + 1, colMax + 1]}");
            Console.WriteLine(maxSum);
        }
        static int[,] ReadMatrix(int rowMax, int colMax)
        {

            int[,] matrix = new int[rowMax, colMax];

            for (int row = 0; row < rowMax; row++)
            {
                int[] matrixElements = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < colMax; col++)
                {
                    matrix[row, col] = matrixElements[col];
                }
            }

            return matrix;
        }
    }
}
