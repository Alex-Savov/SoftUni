using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> honorer = n => Console.WriteLine($"Sir {n}");
            //PrintHonored(Console.ReadLine().Split(), honorer);

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(n => honorer(n));
        }

        //static void PrintHonored(string[] names, Action<string> action)
        //{
        //    foreach (var name in names)
        //    {
        //        action(name);
        //    }
        //}
    }
}
