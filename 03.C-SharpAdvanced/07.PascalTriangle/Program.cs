using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jagArr = new long[n][];
            
            for (int row = 0; row < n; row++)
            {
                jagArr[row] = new long[row + 1];
                jagArr[row][0] = 1;
                jagArr[row][jagArr[row].Length - 1] = 1;

                for (int col = 1; col < jagArr[row].Length - 1; col++)
                {
                    jagArr[row][col] = jagArr[row - 1][col] + jagArr[row - 1][col - 1];
                }
            }

            foreach (var arr in jagArr)
            {
                Console.WriteLine(string.Join(' ', arr));
            }
        }
    }
}
