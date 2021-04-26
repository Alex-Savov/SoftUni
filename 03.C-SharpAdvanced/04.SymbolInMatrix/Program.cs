using System;


namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = ReadMatrix(n, n);
            char symbol = Convert.ToChar(Console.ReadLine());
            bool isFound = false;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (symbol == matrix[row, col])
                    {
                        isFound = true;
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix ");
            }
        }
        static char[,] ReadMatrix(int rowMax, int colMax)
        {

            char[,] matrix = new char[rowMax, colMax];

            for (int row = 0; row < rowMax; row++)
            {
                char[] matrixElements = Console.ReadLine()
                .ToCharArray();
               

                for (int col = 0; col < colMax; col++)
                {
                    matrix[row, col] = matrixElements[col];
                }
            }

            return matrix;
        }
    }
}
