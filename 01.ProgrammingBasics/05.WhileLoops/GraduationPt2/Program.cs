using System;

namespace GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int level = 0;
            double sumGrades = 0;
            int failsCounter = 0;

            while (level < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                sumGrades += grade;

                if (grade < 4)
                {
                    failsCounter++;
                }

                if (failsCounter > 1)
                {
                    break;
                }
                level++;
            }

            if (failsCounter > 1)
            {
                Console.WriteLine($"{name} has been excluded at {level} grade");
            }
            else
            {
                double averageGrade = sumGrades / level;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
