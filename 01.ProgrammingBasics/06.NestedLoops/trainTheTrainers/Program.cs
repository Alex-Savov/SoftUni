using System;

namespace trainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double assasements = 0;
            int presentaion = 0;

            while (presentationName != "Finish" )
            {
                double sumgrades = 0;

                for (int i = 0; i < judges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumgrades += grade;
                }
                sumgrades /= judges;
                Console.WriteLine($"{presentationName} - {sumgrades:f2}.");
                assasements += sumgrades;
                presentaion++;
                presentationName = Console.ReadLine();
            }
            double finalAssessemet = assasements / presentaion;
            Console.WriteLine($"Student's final assessment is {finalAssessemet:f2}.");
        }
    }
}
