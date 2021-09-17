using System;
using System.Linq;

namespace _02.TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            string[][] map = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                map[i] = Console.ReadLine()
                    .ToCharArray()
                    .Select(x => x.ToString())
                    .ToArray();
            }

            int[] mordorCoordinates = GetMordorCoordinates(map);
            int mordorX = mordorCoordinates[0];
            int mordorY = mordorCoordinates[1];
            bool isMordorReached = false;

            string[] commandTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                string move = commandTokens[0];
                int enemySpawnX = int.Parse(commandTokens[1]);
                int enemySpawnY = int.Parse(commandTokens[2]);

                int[] armyCoordinates = GetArmyCoordinates(map);
                int armyX = armyCoordinates[0];
                int armyY = armyCoordinates[1];

                if (map[enemySpawnX][enemySpawnY] == "-")
                {
                    map[enemySpawnX][enemySpawnY] = "O";
                }
                else if (map[enemySpawnX][enemySpawnY] == "A")
                {
                    armor -= 2;
                }

                int[] movementCoordinates = GetMovementCoordinates(map, move, armyCoordinates);

                if (map[movementCoordinates[0]][movementCoordinates[1]] == "O")
                {
                    armor -= 2;
                }

                map = MoveArmy(map, move, movementCoordinates);

                armor--;

                armyCoordinates = GetArmyCoordinates(map);
                armyX = armyCoordinates[0];
                armyY = armyCoordinates[1];

                if (armor <= 0)
                {
                    break;
                }

                if (mordorX == armyX && mordorY == armyY)
                {
                    map[armyX][armyY] = "-";
                    isMordorReached = true;
                    break;
                }

                commandTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            if (armor <= 0 && isMordorReached == false)
            {
                int[] armyCoordinates = GetArmyCoordinates(map);
                map[armyCoordinates[0]][armyCoordinates[1]] = "X";
                Console.WriteLine($"The army was defeated at {armyCoordinates[0]};{armyCoordinates[1]}.");
            }
            else if (isMordorReached)
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
            }

            PrintMap(map);
        }

        public static int[] GetArmyCoordinates(string[][] map)
        {
            int[] coordinates = new int[2];
            int rows = map.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                int cols = map[i].Length;

                for (int j = 0; j < cols; j++)
                {
                    if (map[i][j] == "A")
                    {
                        coordinates[0] = i;
                        coordinates[1] = j;
                    }
                }
            }

            return coordinates;
        }

        public static string[][] MoveArmy(string[][] map, string move, int[] movementCoordinates)
        {
            int[] armyCoordinates = GetArmyCoordinates(map);
            int armyX = armyCoordinates[0];
            int armyY = armyCoordinates[1];
            map[armyX][armyY] = "-";
            map[movementCoordinates[0]][movementCoordinates[1]] = "A";

            return map;
        }

        public static int[] GetMordorCoordinates(string[][] map)
        {
            int[] coordinates = new int[2];
            int rows = map.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                int cols = map[i].Length;

                for (int j = 0; j < cols; j++)
                {
                    if (map[i][j] == "M")
                    {
                        coordinates[0] = i;
                        coordinates[1] = j;
                    }
                }
            }

            return coordinates;
        }

        public static void PrintMap(string[][] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    Console.Write(map[i][j]);
                }

                Console.WriteLine();
            }
        }

        public static int[] GetMovementCoordinates(string[][] map, string move, int[] coordinates)
        {
            int armyX = coordinates[0];
            int armyY = coordinates[1];

            switch (move)
            {
                case "up":
                    if (armyX > 0)
                    {
                        return new int[] { --armyX, armyY };
                    }
                    break;
                case "down":
                    if (armyX < map.GetLength(0) - 1)
                    {
                        return new int[] { ++armyX, armyY };
                    }
                    break;
                case "left":
                    if (armyY > 0)
                    {
                        return new int[] { armyX, --armyY };
                    }
                    break;
                case "right":
                    if (armyY < map[armyX].Length - 1)
                    {
                        return new int[] { armyX, ++armyY };
                    }
                    break;
            }
            return coordinates;
        }
    }
}
