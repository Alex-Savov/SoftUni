using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            //	1.initiate two dictom = naries for the junk and the legendary items
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string legendaryItem = "";
            //  2.initiate while loop
            while (true)
            {
                // 	3.get the input
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> materials = new Dictionary<string, int>();
                for (int i = 0; i < input.Length; i += 2)
                {
                    string material = input[i + 1].ToLower();
                    int value = int.Parse(input[i]);
                    //	4.chek if the input is key material or junk
                    //		if key material
                  
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        //add the value to its current value

                        keyMaterials[material] += value;

                        //check if some of the values got 250
                        //if true, substract 250 from its value and print the output

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;

                            switch (material)
                            {
                                case "shards":
                                    legendaryItem = "Shadowmourne";
                                    break;
                                case "fragments":
                                    legendaryItem = "Valanyr";
                                    break;
                                case "motes":
                                    legendaryItem = "Dragonwrath";
                                    break;
                            }

                            Console.WriteLine($"{legendaryItem} obtained!");
                            break;
                        }
                    }
                    else //		else
                    {
                        //				check if the junk exists, if not - add it
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += value;
                        }
                        else
                        {
                            junk.Add(material, value);
                        }
                    }
                }

                if (legendaryItem != "")
                {
                    break;
                }
            }
            //5.print the remaining key materials in descending order by value, then by name

            foreach (var material in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            //6.print the junk in alphabetic order

            foreach (var material in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
		}
    }
}
