using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] commArgs = commands
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commArgs[0];
                int element = int.Parse(commArgs[1]);

                switch (action)
                {
                    case "Delete":
                        numbers.RemoveAll(x => x == element);
                        break;

                    case "Insert":
                        int index = int.Parse(commArgs[2]);
                        numbers.Insert(index, element);
                        break;

                    default:
                        break;
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
