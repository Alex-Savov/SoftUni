using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = ReadMatrix(new int[n, n]);
            int primeDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        primeDiagonalSum += matrix[row, col];
                    }

                    if (row == (n - 1 - col))
                    {
                        secondaryDiagonalSum += matrix[row, col];
                    }
                }
            }

            int difference = Math.Abs(primeDiagonalSum - secondaryDiagonalSum);

            Console.WriteLine(difference);
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
    }
}
