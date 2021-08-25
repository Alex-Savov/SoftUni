using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVat = num => num * 1.2M;

            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(n => addVat(n))
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:f2}"));
        }
    }
}
