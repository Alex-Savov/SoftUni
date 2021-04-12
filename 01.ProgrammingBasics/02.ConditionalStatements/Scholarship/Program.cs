using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double scholarSoc = Math.Floor(minSalary * 0.35);
            double scholExell = Math.Floor(grade * 25);

            if (income <= minSalary && grade >= 5.5 && scholExell >= scholarSoc)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholExell} BGN");
            }
            else if (income <= minSalary && grade >= 5.5 && scholExell < scholarSoc)
            {
                Console.WriteLine($"You get a Social scholarship {scholarSoc} BGN");
            }
            else if (income > minSalary && grade >=5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholExell} BGN");
            }
            else if (income <= minSalary && grade >= 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {scholarSoc} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            
        }
    }
}
