﻿using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; }  }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("Name: {0}, Age: {1}", Name, Age));
            return output.ToString();
        }
    }
}
