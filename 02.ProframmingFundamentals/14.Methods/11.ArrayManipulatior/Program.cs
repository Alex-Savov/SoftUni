using System;
using System.Linq;

namespace _11.ArrayManipulatior
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int[] arr = LastCountEven(array, 2);

        }
        //•	exchange {index} – splits the array after the given index,
        // and exchanges the places of the two resulting sub-arrays.
        // E.g. [1, 2, 3, 4, 5] -> exchange 2 -> result: [4, 5, 1, 2, 3]
        //o	If the index is outside the boundaries of the array, print “Invalid index”
        static int[] Exchange (int[] arr, int index)
        {
        //    if (index < 0 || index >= arr.Length)
        //    {
        //        Console.WriteLine("Invalid index");
        //        return arr;
        //    }

            for (int i = 0; i <= index; i++)
            {
                int temp = arr[0];
                for (int j = 0; j < arr.Length -1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = temp; 
            }

            return arr;
        }

        //•	max even/odd– returns the INDEX of the max even/odd element ->
        // [1, 4, 8, 2, 3] -> max odd -> print 4
        static int MaxEvenElement (int[] arr)
        {
            int maxValue = int.MinValue;
            int maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (maxValue <= arr[i] && i % 2 == 0)
                {
                    maxValue = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        static int MaxOddElement(int[] arr)
        {
            int maxValue = int.MinValue;
            int maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (maxValue <= arr[i] && i % 2 != 0)
                {
                    maxValue = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        //•	min even/odd – returns the INDEX of the min even/odd element ->
        // [1, 4, 8, 2, 3] -> min even > print 3
        //o	If there are two or more equal min/max elements, return the index
        // of the rightmost one
        //o	If a min/max even/odd element cannot be found, print “No matches”

        static int MinEvenElement(int[] arr)
        {
            int minValue = int.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (minValue >= arr[i] && i % 2 == 0)
                {
                    minValue = arr[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        static int MinOddElement(int[] arr)
        {
            int minValue = int.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (minValue >= arr[i] && i % 2 != 0)
                {
                    minValue = arr[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }


        //•	first {count} even/odd– returns the first {count} elements ->
        // [1, 8, 2, 3] -> first 2 even -> print [8, 2]

        static int[] FirstCountEven (int[]arr, int count)
        {
            int[] result = new int[count];
            int index = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    result[index] = item;
                    index++;
                }
            }
             // adding filter in case in the array are less elements
             // than demanded
            int[] filter = new int[index];

            if (filter.Length < result.Length)
            {
                for (int i = 0; i < filter.Length; i++)
                {
                    filter[i] = result[i];
                }
                return filter;
            }

            return result;
        }
        static int[] FirstCountOdd(int[] arr, int count)
        {
            int[] result = new int[count];
            int index = 0;
            foreach (var item in arr)
            {
                if (item % 2 != 0)
                {
                    result[index] = item;
                    index++;
                }
            }

            // adding filter in case in the array are less elements
            // than demanded

            int[] filter = new int[index];

            if (filter.Length < result.Length)
            {
                for (int i = 0; i < filter.Length; i++)
                {
                    filter[i] = result[i];
                }
                return filter;
            }

            return result;
        }


        //•	last {count} even/odd – returns the last {count} elements ->
        // [1, 8, 2, 3] -> last 2 odd -> print [1, 3]
        //o	If the count is greater than the array length, print “Invalid count”
        //o	If there are not enough elements to satisfy the count, print as many
        // as you can. If there are zero even/odd elements, print an empty array “[]”

        static int[] LastCountEven(int[] arr, int count)
        {
            int[] result = new int[count];
            int index = arr.Length - 1;
            int elementCount = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0)
                {
                    result[index] = arr[i];
                    elementCount++;
                    index--;
                }
            }

            // adding filter in case in the array are less elements
            // than demanded

            int[] filter = new int[elementCount];
            index = arr.Length - 1;

            if (filter.Length < result.Length)
            {
                for (int i = 0; i < filter.Length; i++)
                {
                    filter[i] = result[index];
                    index--;
                }
                return filter;
            }

            return result;
        }
        static int[] LastCountOdd(int[] arr, int count)
        {
            int[] result = new int[count];
            int index = arr.Length - 1;
            int elementCount = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 != 0)
                {
                    result[index] = arr[i];
                    elementCount++;
                    index--;
                }
            }

            // adding filter in case in the array are less elements
            // than demanded

            int[] filter = new int[elementCount];
            index = arr.Length - 1;

            if (filter.Length < result.Length)
            {
                for (int i = 0; i < filter.Length; i++)
                {
                    filter[i] = result[index];
                    index--;
                }
                return filter;
            }

            return result;
        }



        //•	end – stop taking input and print the final state of the array

    }
}
