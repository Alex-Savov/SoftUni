using System;

namespace _01.IntegerAndRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{(decimal.Parse(Console.ReadLine()) / 1000M):f2}");
        }
    }
}
