using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> resourcesLog = new Dictionary<string, double>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                double quantity = double.Parse(Console.ReadLine());

                if (resourcesLog.ContainsKey(resource))
                {
                    resourcesLog[resource] += quantity;
                }
                else
                {
                    resourcesLog.Add(resource, quantity);
                }
            }

            foreach (var resource in resourcesLog)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
