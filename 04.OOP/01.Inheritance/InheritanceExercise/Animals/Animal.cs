﻿using System.Text;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

       public virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"{this.GetType().Name}");
            output.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            output.Append(this.ProduceSound());
            return output.ToString();
        }
    }
}
