using System;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            string output = "";
            switch (animal)
            {
                case "dog":
                    output = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    output = "reptile";
                    break;
                default:
                    output = "unknown";
                    break;
            }
            Console.WriteLine(output);
        }
    }
}
