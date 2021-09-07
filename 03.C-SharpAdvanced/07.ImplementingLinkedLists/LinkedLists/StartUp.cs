using System;

namespace LinkedLists
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 6, 8, 4, 455, 16, 89 };
            CustomLinkedList cll = new CustomLinkedList();

            for (int i = 0; i < numbers.Length; i++)
            {
                cll.AddLast(numbers[i]);
            }

            cll.ForEach(Console.WriteLine);
            Console.WriteLine();

            cll.AddFirst(101);

            cll.ForEach(Console.WriteLine);
            Console.WriteLine();

            int removed = cll.RemoveLast();

            cll.ForEach(Console.WriteLine);
            Console.WriteLine($"Last was removed. Value is {removed}");
            Console.WriteLine();

            int first = cll.RemoveFirst();

            cll.ForEach(Console.WriteLine);
            Console.WriteLine($"First was removed. Value is {first}");
            Console.WriteLine();

            int[] finalNUmber = cll.ToArray();

            for (int i = 0; i < finalNUmber.Length; i++)
            {
                Console.WriteLine($"{i + 1} -> {finalNUmber[i]}");
            }
        }
    }
}
