using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine()
              .Split(' ','|', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();


        }
    }
}
