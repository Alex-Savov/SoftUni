using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Student
    {
        //first name, last name, age and hometown.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Hometown { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] studentData = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student
                {
                    FirstName = studentData[0],
                    LastName = studentData[1],
                    Age = int.Parse(studentData[2]),
                    Hometown = studentData[3]
                };

                students.Add(student);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            foreach (var student in students.Where(x => x.Hometown == input))
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
