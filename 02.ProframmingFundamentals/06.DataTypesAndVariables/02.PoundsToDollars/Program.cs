using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{(decimal.Parse(Console.ReadLine()) * 1.31M):f3}");
        }
    }
}
