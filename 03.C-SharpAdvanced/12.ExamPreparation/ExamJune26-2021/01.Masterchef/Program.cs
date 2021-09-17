using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Stack<int> freshnessLevel = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Dictionary<string, List<int>> dishes = new Dictionary<string, List<int>>();
            dishes.Add("Dipping sauce", new List<int>() { 150, 0 });
            dishes.Add("Green salad", new List<int>() { 250, 0 });
            dishes.Add("Chocolate cake", new List<int>() { 300, 0 });
            dishes.Add("Lobster", new List<int>() { 400, 0 });

            while (ingredients.Count != 0 && freshnessLevel.Count != 0)
            {
                int ingredient = ingredients.Dequeue();
                int freshness = freshnessLevel.Pop();

                if (ingredient == 0)
                {
                    freshnessLevel.Push(freshness);
                    continue;
                }

                int product = ingredient * freshness;
                bool isDishMade = false;

                foreach (var dish in dishes.OrderByDescending(p => p.Value[0]))
                {
                    if (dish.Value[0] == product)
                    {
                        dish.Value[1]++;
                        isDishMade = true;
                        break;
                    }
                }

                if (!isDishMade)
                {
                    ingredient += 5;
                    ingredients.Enqueue(ingredient);
                }
            }

            if (dishes.Any(d => d.Value[1] == 0))
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
            else
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var dish in dishes
                .OrderByDescending(d => d.Value[1])
                .ThenBy(d => d.Key)
                .Where(d => d.Value[1] != 0))
            {
                Console.WriteLine($" # {dish.Key} --> {dish.Value[1]}");
            }
        }
    }
}
