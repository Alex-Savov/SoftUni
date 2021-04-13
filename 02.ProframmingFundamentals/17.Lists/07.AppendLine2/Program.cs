using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.AppendLine2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> arr = Console.ReadLine()
               .Split('|', StringSplitOptions.RemoveEmptyEntries)
               .Reverse()
               .ToList();

            List<string> result = new List<string>();

            for (int i = 0; i < arr.Count; i++)
            {
                string[] elements = arr[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in elements)
                {
                    result.Add(element);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
