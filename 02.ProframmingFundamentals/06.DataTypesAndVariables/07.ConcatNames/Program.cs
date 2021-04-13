using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine("{0}{1}{2}", firstName,delimiter,secName);
        }
    }
}
