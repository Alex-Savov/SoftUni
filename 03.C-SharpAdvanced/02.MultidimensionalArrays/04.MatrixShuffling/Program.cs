using System;
using System.Linq;

namespace _04.MatrixShuffling
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

            string[,] matrix = new string[maxRows, maxCols];
            ReadMatrix(matrix);

            while (true)
            {
                string inputCommand = Console.ReadLine();

                if (inputCommand == "END")
                {
                    break;
                }

                string[] tokens = inputCommand
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (IsCommandValid(maxRows, maxCols, tokens))
                {
                    int rowFirst = int.Parse(tokens[1]);
                    int colFirst = int.Parse(tokens[2]);
                    int rowSecond = int.Parse(tokens[3]);
                    int colSecond = int.Parse(tokens[4]);

                    string temp = matrix[rowFirst, colFirst];
                    matrix[rowFirst, colFirst] = matrix[rowSecond, colSecond];
                    matrix[rowSecond, colSecond] = temp;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                PrinMatrix(matrix);
            }
        }

        private static bool IsCommandValid(int maxRows, int maxCols, string[] tokens)
        {
            if (tokens.Length == 5 && tokens[0] == "swap")
            {
                int rowFirst = int.Parse(tokens[1]);
                int colFirst = int.Parse(tokens[2]);
                int rowSecond = int.Parse(tokens[3]);
                int colSecond = int.Parse(tokens[4]);

                if ((rowFirst >= 0 && rowFirst < maxRows)
                   && (colFirst >= 0 && colFirst < maxCols)
                   && (rowSecond >= 0 && rowSecond < maxRows)
                   && (colSecond >= 0 && colSecond < maxCols))
                {
                    return true;
                }
            }

            return false;
        }

        private static void ReadMatrix(string[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }

        static void PrinMatrix(string[,] matrix)
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
