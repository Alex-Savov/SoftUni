using System;
using System.Collections.Generic;
using System.Linq;

public class SetCover
{
    public static void Main(string[] args)
    {
        int[] universe = Console.ReadLine()
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Skip(1)
            .Select(int.Parse)
            .ToArray();
        
        int numberOfSets = int.Parse(Console.ReadLine()
             .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
             .Last());

        int[][] sets = new int[numberOfSets][];

        for (int i = 0; i < numberOfSets; i++)
        {
            sets[i] = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        List<int[]> selectedSets = ChooseSets(sets.ToList(), universe.ToList());
        Console.WriteLine($"Sets to take ({selectedSets.Count}):");

        foreach (int[] set in selectedSets)
        {
            Console.WriteLine($"{{ {string.Join(", ", set)} }}");
        }
    }

    public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
    {
        List<int[]> selectedSets = new List<int[]>();

        while (universe.Count > 0)
        {
            int[] currentSet = sets
                .OrderByDescending(s => s.Count(universe.Contains))
                .First();

            selectedSets.Add(currentSet);
            sets.Remove(currentSet);

            for (int i = 0; i < universe.Count; i++)
            {
                if (currentSet.Any(n => n == universe[i]))
                {
                    universe.Remove(universe[i]);
                    i--;
                }
            }
        }
        return selectedSets;
    }
}
