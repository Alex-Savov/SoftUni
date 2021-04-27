using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int[,] matrix3x3 = new int[3, 3];

            int maxRows = dimensions[0];
            int maxCols = dimensions[1];

            int[,] matrix = ReadMatrix(new int[maxRows, maxCols]);
            int sumMatrix = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int[,] currentMatrix = Get3x3Matrix(matrix, row, col);
                    int currentSum = GetMatrixSum(currentMatrix);

                    if (sumMatrix < currentSum)
                    {
                        sumMatrix = currentSum;
                        matrix3x3 = currentMatrix;
                    }
                }
            }

            Console.WriteLine($"Sum = {sumMatrix}");
            PrinMatrix(matrix3x3);
        }
        static int[,] ReadMatrix(int[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
        static int[,] Get3x3Matrix (int[,] matrix, int rowStart, int colStart)
        {
            int[,] result = new int[3, 3];

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    result[row, col] = matrix[rowStart + row, colStart + col];
                }
            }

            return result;
        }

        static int GetMatrixSum(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            return sum;
        }
        static void PrinMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
