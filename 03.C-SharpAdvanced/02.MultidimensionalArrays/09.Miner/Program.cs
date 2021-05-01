using System;
using System.Linq;

namespace _0._9.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            char[,] field = new char[n, n];
            ReadMatrix(field);
            int minerRow = 0;
            int minerCol = 0;
            int coals = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (field[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }

                    if (field[row, col] == 'c')
                    {
                        coals++;
                    }
                }
            }

            int coalCounter = 0;
            bool isGameOver = false;

            for (int i = 0; i < commands.Length; i++)
            {
                string command = commands[i];

                if (command == "right" && (minerCol + 1 < n))
                {
                    minerCol++;
                    char fieldElement = field[minerRow, minerCol];

                    if (fieldElement == 'e')
                    {
                        isGameOver = true;
                        break;
                    }

                    if (fieldElement == 'c')
                    {
                        coalCounter++;
                        field[minerRow, minerCol] = '*';
                    }
                }
                else if (command == "left" && (minerCol - 1 >= 0))
                {
                    minerCol--;
                    char fieldElement = field[minerRow, minerCol];

                    if (fieldElement == 'e')
                    {
                        isGameOver = true;
                        break;
                    }

                    if (fieldElement == 'c')
                    {
                        coalCounter++;
                        field[minerRow, minerCol] = '*';
                    }
                }
                else if (command == "down" && (minerRow + 1 < n))
                {
                    minerRow++;
                    char fieldElement = field[minerRow, minerCol];

                    if (fieldElement == 'e')
                    {
                        isGameOver = true;
                        break;
                    }

                    if (fieldElement == 'c')
                    {
                        coalCounter++;
                        field[minerRow, minerCol] = '*';
                    }
                }
                else if (command == "up" && (minerRow - 1 >= 0))
                {
                    minerRow--;
                    char fieldElement = field[minerRow, minerCol];

                    if (fieldElement == 'e')
                    {
                        isGameOver = true;
                        break;
                    }

                    if (fieldElement == 'c')
                    {
                        coalCounter++;
                        field[minerRow, minerCol] = '*';
                    }
                }

                if (coals == coalCounter)
                {
                    Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                    break;
                }
            }

            if (isGameOver)
            {
                Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
            }
            else if (coals != coalCounter)
            {
                Console.WriteLine($"{coals - coalCounter} coals left. ({minerRow}, {minerCol})");
            }
        }
        private static void ReadMatrix(char[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .Select(x => Convert.ToChar(x))
                   .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
