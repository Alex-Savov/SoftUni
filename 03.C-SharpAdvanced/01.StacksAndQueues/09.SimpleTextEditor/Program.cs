using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Stack<string> text = new Stack<string>();
            text.Push("");

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                string command = input[0];

                switch (command)
                {
                    case "1":
                        string inputText = $"{text.Peek()}{input[1]}";
                        text.Push(inputText);
                        break;
                    case "2":
                        int count = int.Parse(input[1]);
                        int startIndex = text.Peek().Length - count;
                        string substring = text.Peek().Remove(startIndex);
                        text.Push(substring);
                        break;
                    case "3":
                        int index = (int.Parse(input[1]) - 1 );
                        Console.WriteLine(text.Peek()[index]);
                        break;
                    case "4":
                        text.Pop();
                        break;
                    default:
                        break;
                }
            }          
        }
    }
}