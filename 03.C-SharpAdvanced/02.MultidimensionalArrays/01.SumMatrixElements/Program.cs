using System;
using System.Linq;

namespace _01.SumMatrixElements
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
            int matrixSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrixSum += matrix[row, col];
                }
            }

            Console.WriteLine(matrixSize[0]);
            Console.WriteLine(matrixSize[1]);
            Console.WriteLine(matrixSum);
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
