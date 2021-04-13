﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            //while (true)
            //{
            //    bool isNoEquals = true;

            //    for (int i = 0; i < numbers.Count - 1; i++)
            //    {
            //        if (numbers[i] == numbers[i + 1])
            //        {
            //            isNoEquals = false;
            //            numbers[i] += numbers[i + 1];
            //            numbers.RemoveAt(i + 1);
            //        }
            //    }

            //    if (isNoEquals)
            //    {
            //        break;
            //    }
            //}

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
