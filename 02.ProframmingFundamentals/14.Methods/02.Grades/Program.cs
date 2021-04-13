﻿using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            string result = GradeValidator(grade);
            Console.WriteLine(result);
        }
        static string GradeValidator(double grade)
        {
            string result = string.Empty;

            if (grade >= 2.0 && grade < 3.0)
            {
                result = "Fail";
            }
            else if (grade >= 3.0 && grade < 3.5)
            {
                result = "Poor";
            }
            else if (grade >= 3.5 && grade < 4.5)
            {
                result = "Good";
            }
            else if (grade >= 4.5 && grade < 5.5)
            {
                result = "Very good";
            }
            else if (grade >= 5.5 && grade <= 6.0)
            {
                result = "Excellent";
            }

            return result;
        }
    }
}
