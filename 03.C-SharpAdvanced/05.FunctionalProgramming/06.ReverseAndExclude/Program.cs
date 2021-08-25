using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> divisibleNumber = (num1, num2) => num1 % num2 != 0;
            string input = Console.ReadLine();
            int divider = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(' ', input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(number => divisibleNumber(number, divider))
                .Reverse()));
        }
    }
}
