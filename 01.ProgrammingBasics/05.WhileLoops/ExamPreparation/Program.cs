using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
 
            int badGradesCount = 0;
            int sumGrades = 0;
            int problemCount = 0;
            string lastProblem = "";

            string problem = Console.ReadLine(); 

            while (problem != "Enough")
            {
                lastProblem = problem;
                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    badGradesCount++;
                }

                if (badGrades == badGradesCount)
                {
                    break;
                }

                sumGrades += grade;
                problemCount++;
                problem = Console.ReadLine();
            }

            if (badGrades == badGradesCount)
            {
                Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
            }
            else
            {
                double avarage = 1.0 * sumGrades / problemCount;
                Console.WriteLine($"Average score: {avarage:f2}\n" +
                            $"Number of problems: {problemCount}\n" +
                                  $"Last problem: {lastProblem}");
            }
        }
    }
}
