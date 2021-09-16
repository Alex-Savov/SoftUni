using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                people.Add(new Person(tokens[0], int.Parse(tokens[1]), tokens[2]));

                input = Console.ReadLine();
            }

            int indexComparator = int.Parse(Console.ReadLine()) - 1;
            int equals = 0;
            int different = 0;
            Person comparator = people[indexComparator];

            foreach (var item in people)
            {
                if (item.CompareTo(comparator) == 0)
                {
                    equals++;
                }
                else
                {
                    different++;
                }
            }
            if (equals != 1)
            {
                Console.WriteLine($"{equals} {different} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
