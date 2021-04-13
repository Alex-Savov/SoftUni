using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(i);
                Console.WriteLine();
            }
        }

        static void PrintLine(int maxLenght)
        {
            for (int i = 1; i <= maxLenght; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
