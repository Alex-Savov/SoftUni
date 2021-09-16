using System;
using System.Linq;

namespace IteratorsAndComparators
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(stones);

            Console.WriteLine(string.Join(", ", lake));

            //string[] tokens = Console.ReadLine()
            //    .Split(new string[] {" ", ", "}, StringSplitOptions.RemoveEmptyEntries);
            //CustomStack<string> myStack = new CustomStack<string>();

            //while (tokens[0].ToLower() != "end")
            //{
            //    string command = tokens[0].ToLower();

            //    if (command == "push")
            //    {
            //        myStack.Push(tokens.Skip(1).ToArray());
            //    }
            //    else if (command == "pop")
            //    {
            //       myStack.Pop();
            //    }

            //    tokens = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //}

            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}
            //    string[] input = Console.ReadLine()
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //    ListyIterator<string> listy = new ListyIterator<string>(input.Skip(1).ToArray());

            //    while (input[0].ToLower() != "end")
            //    {
            //        string command = input[0];

            //        switch (command.ToLower())
            //        {
            //            case "move":
            //                Console.WriteLine(listy.Move());
            //                break;
            //            case "hasnext":
            //                Console.WriteLine(listy.HasNext());
            //                break;
            //            case "print":

            //                try
            //                {
            //                    listy.Print();
            //                }
            //                catch (ArgumentException ae)
            //                {
            //                    Console.WriteLine(ae.Message);
            //                }

            //                break;
            //            case "printall":
            //                listy.PrintAll();
            //                break;
            //            default:
            //                break;

            //        }

            //        input = Console.ReadLine()
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    }
        }
    }
}
