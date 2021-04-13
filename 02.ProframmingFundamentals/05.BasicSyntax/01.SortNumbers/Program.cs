using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int temp = 0;

            if (n1 < n3)
            {
                temp = n1;
                n1 = n3;
                n3 = temp;
            }
            if (n1 < n2)
            {
                temp = n1;
                n1 = n2;
                n2 = temp;
            }
            if (n2 < n3)
            {
                temp = n2;
                n2 = n3;
                n3 = temp;
            }

            Console.WriteLine($"{n1}\n{n2}\n{n3}");
        }
    }
}
