using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 56 };
            int[] arr2 = new int[] { 1, 2, 3 };
            Console.WriteLine(new EqualityScale<int[] >(arr1,arr1).AreEqual());
        }
    }
}
