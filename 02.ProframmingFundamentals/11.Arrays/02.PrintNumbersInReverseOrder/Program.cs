using System;
using System.Linq;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(' ', numbers.Reverse()));
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
