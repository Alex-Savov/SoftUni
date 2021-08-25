using System;
using System.Collections.Generic;


namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(string, int)> people = new List<(string, int)>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                people.Add((input[0], int.Parse(input[1])));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<(string, int), bool> conditionFunc = GetAgeCondition(condition, age);
            Func<(string, int), string> formatterFunc = GetFormat(format);

            PrintPeople(people, conditionFunc, formatterFunc);
        }

        static void PrintPeople(List<(string, int)> people,
            Func<(string, int), bool> condition,
            Func<(string, int), string> formater)
        {
            foreach (var person in people)
            {
                if (condition(person))
                {
                    Console.WriteLine(formater(person));
                }
            }
        }

        static Func<(string, int), bool> GetAgeCondition(string filter, int age)
        {
            switch (filter)
            {
                case "younger": return p => p.Item2 < age;
                case "older": return p => p.Item2 >= age;
                default:
                    return null;
            }
        }

        static Func<(string, int), string> GetFormat(string formater)
        {
            switch (formater)
            {
                case "name": return p => p.Item1;
                case "age": return p => p.Item2.ToString();
                case "name age": return p => $"{p.Item1} - {p.Item2}";
                default:
                    return null;
            }
        }
    }
}
