using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string typeAnimal = Console.ReadLine();
            List<Animal> animals = new List<Animal>();
            
            while (typeAnimal != "Beast!")
            {
                string[] animalData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string Name = animalData[0];
                int age;

                if ((!int.TryParse(animalData[1], out age))
                    || Name == string.Empty
                    || age < 0)
                {
                    Console.WriteLine("Invalid input!");
                    typeAnimal = Console.ReadLine();
                    continue;
                }
                
                switch (typeAnimal)
                {
                    case "Dog":
                        animals.Add(new Dog(Name, age, animalData[2]));
                        break;
                    case "Cat":
                        animals.Add(new Cat(Name, age, animalData[2]));
                        break;
                    case "Frog":
                        animals.Add(new Frog(Name, age, animalData[2]));
                        break;
                    case "Kitten":
                        animals.Add(new Kitten(Name, age));
                        break;
                    case "Tomcat":
                        animals.Add(new Tomcat(Name, age));
                        break;
                    default:
                        break;
                }
                typeAnimal = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
