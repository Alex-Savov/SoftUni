using System;
using System.Collections.Generic;


namespace _01.GenericBoxOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();
            string[] thirdInput = Console.ReadLine().Split();

            bool isDrunk = secondInput[2].ToLower() == "drunk" ? true : false;
            Threeuple<string, string, string> first = new Threeuple<string, string, string>($"{firstInput[0]} {firstInput[1]}", firstInput[2], firstInput[3]);
            Threeuple<string, int, bool> second = new Threeuple<string, int, bool>(secondInput[0], int.Parse(secondInput[1]), isDrunk);
            Threeuple<string, double, string> third = new Threeuple<string, double, string>(thirdInput[0], double.Parse(thirdInput[1]), thirdInput[2]);

            Console.WriteLine(first.ToString());
            Console.WriteLine(second.ToString());
            Console.WriteLine(third.ToString());

            

            //int n = int.Parse(Console.ReadLine());
            //List<double> elements = new List<double>();

            //for (int i = 0; i < n; i++)
            //{
            //    elements.Add(double.Parse(Console.ReadLine()));
            //}

            //double elementToCompare = double.Parse(Console.ReadLine());

            //int count = new Box<string>().CountCompare(elements, elementToCompare);

            //Console.WriteLine(count);


            //int n = int.Parse(Console.ReadLine());
            //List<int> elements = new List<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    elements.Add(int.Parse(Console.ReadLine()));
            //}

            //int[] swapIndexes = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            //Box<int> box = new Box<int>(elements);
            //box.Swap(elements, swapIndexes[0], swapIndexes[1]);
            //Console.WriteLine(box.ToString());



        }
    }
}
