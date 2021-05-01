using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            ReadMatrix(matrix);

            string[] bombs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < bombs.Length; i++)
            {
                int[] bombsCoordinates = bombs[i]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int rowBomb = bombsCoordinates[0];
                int colBomb = bombsCoordinates[1];
                int bombPower = matrix[rowBomb, colBomb];

                if (matrix[rowBomb, colBomb] <= 0)
                {
                    continue;
                }

                BombExplosion(matrix, rowBomb, colBomb, bombPower);
            }

            int activeCells = 0;
            int sumActiveCells = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        activeCells++;
                        sumActiveCells += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {activeCells}");
            Console.WriteLine($"Sum: {sumActiveCells}");
            PrinMatrix(matrix);
        }

        private static void BombExplosion(int[,] matrix, int row, int col, int bombPower)
        {
            //1 2 3
            //4 5 6      5 = bomb location
            //7 8 9

            if (row - 1 >= 0)
            {
                if (matrix[row - 1, col] > 0)
                {
                    matrix[row - 1, col] -= bombPower;          //1 (2) 3  row - 1
                }
                
                if (col - 1 >= 0 && matrix[row - 1, col - 1] > 0)
                {
                    matrix[row - 1, col - 1] -= bombPower;  //(1) 2 3 row - 1
                }

                if (col + 1 < matrix.GetLength(1) && matrix[row - 1, col + 1] > 0)
                {
                    matrix[row - 1, col + 1] -= bombPower;  //1 2 (3)  row - 1
                }
            }

            if (col - 1 >= 0 && matrix[row, col - 1] > 0)
            {
                matrix[row, col - 1] -= bombPower;          //(4) 5 6  row
            }

            if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] > 0)
            {
                matrix[row, col + 1] -= bombPower;          //4 5 (6)  row
            }

            matrix[row, col] = 0;                           //4 (5) 6  row

            if (row + 1 < matrix.GetLength(0))
            {
                if (matrix[row + 1, col] > 0)
                {
                    matrix[row + 1, col] -= bombPower;          //7 (8) 9  row + 1
                }
                
                if (col - 1 >= 0 && matrix[row + 1, col - 1] > 0)
                {
                    matrix[row + 1, col - 1] -= bombPower;  //(7) 8 9  row + 1
                }

                if (col + 1 < matrix.GetLength(1) && matrix[row + 1, col + 1] > 0)
                {
                    matrix[row + 1, col + 1] -= bombPower;  //7 8 (9)  row + 1
                }
            }
        }

        private static void ReadMatrix(int[,] matrix)
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

