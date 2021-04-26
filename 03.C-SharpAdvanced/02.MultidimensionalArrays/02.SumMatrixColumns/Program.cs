using System;
using System.Linq;

namespace _02.SumMatrixColumns
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

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int colSum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    colSum += matrix[row, col];
                }

                Console.WriteLine(colSum);
            }
        }
        static int[,] ReadMatrix(int rowMax, int colMax)
        {

            int[,] matrix = new int[rowMax, colMax];

            for (int row = 0; row < rowMax; row++)
            {
                int[] matrixElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
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
