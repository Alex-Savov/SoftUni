using System;

namespace BonusSpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            string direction = "right";
            int row = 0;
            int col = 0;

            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "right")
                {
                    if (col == n || matrix[row, col] != 0)
                    {
                        direction = "down";
                        i--;
                        col--;
                        row++;
                        continue;
                    }

                    matrix[row, col] = i;
                    col++;
                }

                if (direction == "down")
                {
                    if (row == n || matrix[row, col] != 0)
                    {
                        direction = "left";
                        i--;
                        row--;
                        col--;
                        continue;
                    }

                    matrix[row, col] = i;
                    row++;
                }

                if (direction == "left")
                {
                    if (col == -1 || matrix[row, col] != 0)
                    {
                        direction = "up";
                        i--;
                        row--;
                        col++;
                        continue;
                    }

                    matrix[row, col] = i;
                    col--;
                }

                if (direction == "up")
                {
                    if (row == -1 || matrix[row, col] != 0)
                    {
                        direction = "right";
                        i--;
                        row++;
                        col++;
                        continue;
                    }

                    matrix[row, col] = i;
                    row--;
                }
            }

            PrintMatrix(matrix);
        }
        private static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int rowmtx = 0; rowmtx < n; rowmtx++)
            {
                for (int colmtx = 0; colmtx < n; colmtx++)
                {
                    Console.Write($"{matrix[rowmtx, colmtx]:d2} ");
                }
                Console.WriteLine();
            }
        }
    }
}
