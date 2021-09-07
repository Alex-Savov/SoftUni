using System;

namespace CustomStacksQueuesLists
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack testStack = new CustomStack();

            for (int i = 0; i < 8; i++)
            {
                testStack.Push(i);
            }

            Console.WriteLine($"testStack count is: {testStack.Count}");
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Popped element: {testStack.Pop()}");
            }

            Console.WriteLine();
            Console.WriteLine($"testStack count is: {testStack.Count}");

            Console.WriteLine($"Peeked element: {testStack.Peek()}");
            Console.WriteLine();
            Console.WriteLine("Elements in testStack are:");
            testStack.ForEach(n => Console.WriteLine($"Element: {n}"));

            testStack.Clear();
            Console.WriteLine($"testStack count after Clear method is {testStack.Count}");
            Console.WriteLine();
            CustomList testList = new CustomList();

            for (int i = 0; i < 6; i++)
            {
                testList.Add(i);
            }

            for (int i = 0; i < testList.Count; i++)
            {
                Console.Write($"{testList[i]} ");
            }

            Console.WriteLine();
            int removed = testList.RemoveAt(3);

            Console.WriteLine($"We have removed element at index 3 which is {removed}");
            Console.WriteLine("This is what we have after removing: ");

            for (int i = 0; i < testList.Count; i++)
            {
                Console.Write($"{testList[i]} ");
            }

            Console.WriteLine();

            removed = testList.RemoveAt(3);

            Console.WriteLine($"We have removed element at index 3 which is {removed}");
            Console.WriteLine("This is what we have after removing: ");

            for (int i = 0; i < testList.Count; i++)
            {
                Console.Write($"{testList[i]} ");
            }

            Console.WriteLine();

            testList.InsertAt(2, 7);

            Console.WriteLine("We have just inserted 7 at index 2. Now the list looks like:");

            for (int i = 0; i < testList.Count; i++)
            {
                Console.Write($"{testList[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("Now lets check if we have the number 1 in our list");
            string result = testList.Contains(1) ? "YES" : "NO";
            Console.WriteLine($"Answer is: {result}");
            Console.WriteLine();

            Console.WriteLine("Now lets swap elements at indexes 1 and 4");
            testList.Swap(1, 4);

            for (int i = 0; i < testList.Count; i++)
            {
                Console.Write($"{testList[i]} ");
            }
            
            testList.Clear();
            Console.WriteLine();
            Console.WriteLine($"testList count after Clear method is: {testList.Count}");
        }
    }
}
