using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> courses = new Dictionary<string,List<string>>();
            
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandArgs = input
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = commandArgs[0];
                string studentName = commandArgs[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string> { { studentName} });
                }

                input = Console.ReadLine();
            }

           courses =  courses.OrderByDescending(x => x.Value.Count())
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");
                Console.WriteLine($"-- {string.Join("\n-- ", course.Value.OrderBy(x => x))}");
            }
        }
    }
}
