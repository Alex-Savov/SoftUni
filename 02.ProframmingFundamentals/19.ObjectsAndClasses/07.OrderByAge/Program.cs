using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] userData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (userData[0] == "End")
                {
                    break;
                }

                people.Add(new Person
                {
                    Name = userData[0],
                    ID = userData[1],
                    Age = int.Parse(userData[2])
                });
            }

            Console.WriteLine(string.Join(Environment.NewLine, people
                .OrderBy(p => p.Age)
                .ThenBy(p => p.Name))
                .ToString());
        }
    }
}
