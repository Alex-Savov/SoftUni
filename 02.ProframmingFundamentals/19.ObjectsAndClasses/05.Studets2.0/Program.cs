using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Studets2._0
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
                string firstName = studentData[0];
                string lastName = studentData[1];
                int age = int.Parse(studentData[2]);
                string hometown = studentData[3];

                bool isStudentExisting = students
                    .Any(x => x.FirstName == firstName && x.LastName == lastName);

                if (isStudentExisting)
                {
                    foreach (var item in students
                        .Where(x => x.FirstName == firstName && x.LastName == lastName))
                    {
                        item.Age = age;
                        item.Hometown = hometown;
                    }
                }
                else
                {
                    students.Add(new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown
                    });
                }

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
