using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isUpper = word => char.IsUpper(word[0]);

            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .Where(w => isUpper(w))));
        }
    }
}
