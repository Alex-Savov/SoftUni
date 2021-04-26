using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeSquareMtx = int.Parse(Console.ReadLine());

            int[,] matrix = ReadMatrix(sizeSquareMtx, sizeSquareMtx);
            int diagonalSum = 0;

            for (int row = 0; row < sizeSquareMtx; row++)
            {
                for (int col = 0; col < sizeSquareMtx; col++)
                {
                    if (row == col)
                    {
                        diagonalSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(diagonalSum);
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
