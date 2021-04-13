using System;

namespace _01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	0 - 2 – baby; 
            //•	3 - 13 – child; 
            //•	14 - 19 – teenager;
            //•	20 - 65 – adult;
            //•	>= 66 – elder;

            int age = int.Parse(Console.ReadLine());
            string output = "";

            if (age >= 0 && age <= 2)
            {
                output = "baby";
            }
            else if (age <= 13)
            {
                output = "child";
            }
            else if (age <= 19)
            {
                output = "teenager";
            }
            else if (age <= 65)
            {
                output = "adult";
            }
            else if (age > 65)
            {
                output = "elder";
            }

            Console.WriteLine(output);
        }
    }
}
