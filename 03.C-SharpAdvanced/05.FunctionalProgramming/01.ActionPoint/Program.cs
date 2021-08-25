using System;
using System.Linq;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Action<string> printString = n => Console.WriteLine(n);

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(n => printString(n));
        }
    }
}
