using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string output = "";
            switch (country)
            {
                case "USA":
                case "England":
                    output = "English";
                    break;
                case "Spain":
                case "Argentina ":
                case "Mexico":
                    output = "Spanish";
                    break;
                default:
                    output = "unknown";
                    break;
            }
            Console.WriteLine(output);
        }
    }
}
