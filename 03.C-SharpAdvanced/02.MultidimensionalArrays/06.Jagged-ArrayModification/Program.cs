using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[maxRows][];

            ReadMatrixFromConsole(matrix);

            AnalazyngMAtrix(matrix);

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] commandArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0].ToLower();
                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);
                double value = double.Parse(commandArgs[3]);

                if ((row >= 0 && row < matrix.GetLength(0))
                    && (col >= 0 && col < matrix[row].Length))
                {
                    if (action == "add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (action == "subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(double[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(' ', matrix[i]));
            }
        }

        private static void AnalazyngMAtrix(double[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] *= 2;
                        matrix[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] /= 2;
                    }

                    for (int k = 0; k < matrix[i + 1].Length; k++)
                    {
                        matrix[i + 1][k] /= 2;
                    }
                }
            }
        }

        private static void ReadMatrixFromConsole(double[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                matrix[i] = new double[input.Length];

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i][j] = input[j];
                }
            }
        }
    }
}
