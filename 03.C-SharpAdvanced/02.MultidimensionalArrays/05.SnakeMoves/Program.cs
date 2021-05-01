using System;
using System.Linq;

namespace _05.SnakeMoves
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

            char[,] snakeMtx = new char[maxRows, maxCols];
            int elementCounter = 0;
            string snake = Console.ReadLine();
            

            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    if (row % 2 == 0)
                    {
                        snakeMtx[row, col] = snake[elementCounter];
                    }
                    else
                    {
                        snakeMtx[row, maxCols - 1 - col] = snake[elementCounter];
                    }

                    elementCounter++;

                    if (elementCounter == snake.Length)
                    {
                        elementCounter = 0;
                    }
                }
            }

            PrinMatrix(snakeMtx);
        }
        static void PrinMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
