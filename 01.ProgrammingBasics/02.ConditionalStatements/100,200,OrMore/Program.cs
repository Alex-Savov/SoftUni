using System;

namespace _100_200_OrMore
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string output = "";

            if (n < 100)
            {
                output = "Less than 100";
            }
            else if (n >= 100 && n <= 200)
            {
                output = "Between 100 and 200";
            }
            else
            {
                output = "Greater than 200";
            }

            Console.WriteLine(output);
        }
    }
}
