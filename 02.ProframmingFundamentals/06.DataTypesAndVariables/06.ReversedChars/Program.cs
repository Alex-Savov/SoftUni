using System;

namespace _06.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            for (int i = 0; i < 3; i++)
            {
                str += Console.ReadLine();
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write($"{str[i]} ");
            }
        }
    }
}
