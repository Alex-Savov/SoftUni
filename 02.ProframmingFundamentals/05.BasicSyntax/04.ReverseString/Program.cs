﻿using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reverced = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverced += word[i];
            }

            Console.WriteLine(reverced);
        }
    }
}
