using System;
using System.Collections.Generic;

namespace Problem_1.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            //List<string> names = new List<string>();

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {

                names.Add(Console.ReadLine());
                //string name = Console.ReadLine();

                //if (!names.Contains(name))
                //{
                //    names.Add(name);
                //}
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
