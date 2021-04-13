using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            CharsInRange(ch1, ch2);
        }
        static void CharsInRange (char first, char second)
        {
            if (first < second)
            {
                for (int i = first + 1; i < second; i++)
                {
                    char ch = Convert.ToChar(i);
                    Console.Write("{0} ", ch);
                }
            }
            else
            {
                for (int i = second + 1; i < first; i++)
                {
                    char ch = Convert.ToChar(i);
                    Console.Write("{0} ", ch);
                }
            }
        }
    }
}
