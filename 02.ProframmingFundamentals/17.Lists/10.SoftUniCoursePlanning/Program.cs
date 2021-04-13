using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] commandArgs = command
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string lessonTitle = commandArgs[1];

                if (action == "Add")
                {
                    if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Add(lessonTitle);
                    }
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Insert(index, lessonTitle);
                    }
                }
                else if (action == "Remove")
                {
                    if (schedule.Contains(lessonTitle))
                    {
                        string lessonExercise = $"{lessonTitle}-Exercise";

                        if (schedule.Contains(lessonExercise))
                        {
                            schedule.Remove(lessonExercise);
                        }
                        schedule.Remove(lessonTitle);
                    }
                }
                else if (action == "Swap")
                {
                    string secondLesson = commandArgs[2];
                    if (schedule.Contains(lessonTitle)
                       && schedule.Contains(secondLesson))
                    {
                        int firstLessonIndex = schedule.IndexOf(lessonTitle);
                        int secondLessonIndex = schedule.IndexOf(secondLesson);

                        schedule[firstLessonIndex] = secondLesson;
                        schedule[secondLessonIndex] = lessonTitle;

                        string firstLessonExercise = $"{lessonTitle}-Exercise";
                        string secondLessonExercise = $"{secondLesson}-Exercise";

                        if (schedule.Contains(firstLessonExercise))
                        {
                            schedule.Remove(firstLessonExercise);
                            firstLessonIndex = schedule.IndexOf(lessonTitle);
                            schedule.Insert(++firstLessonIndex, firstLessonExercise);
                        }

                        if (schedule.Contains(secondLessonExercise))
                        {
                            schedule.Remove(secondLessonExercise);
                            secondLessonIndex = schedule.IndexOf(secondLesson);
                            schedule.Insert(++secondLessonIndex, secondLessonExercise);
                        }
                    }
                }
                else if (action == "Exercise")
                {
                    string lessonExercise = $"{lessonTitle}-Exercise";

                    if (!schedule.Contains(lessonTitle))
                    {
                        schedule.Add(lessonTitle);
                        schedule.Add(lessonExercise);
                    }
                    else
                    {
                        int lessonIndex = schedule.IndexOf(lessonTitle);
                        schedule.Insert(lessonIndex + 1, lessonExercise);
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
