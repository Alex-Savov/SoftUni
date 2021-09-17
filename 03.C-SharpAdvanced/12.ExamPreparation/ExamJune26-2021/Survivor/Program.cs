using System;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRows = int.Parse(Console.ReadLine());
            string[][] beach = new string[numberRows][];

            for (int i = 0; i < numberRows; i++)
            {
                beach[i] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string commandInput;
            int playerTokens = 0;
            int opponentTokens = 0;

            while ((commandInput = Console.ReadLine().ToLower()) != "gong")
            {
                string[] tokens = commandInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command.ToLower() == "find")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);

                    if (IndexValidation(beach, row, col))
                    {
                        if (IsCellContainsToken(beach, row, col))
                        {
                            playerTokens++;
                            beach[row][col] = "-";
                        }
                    }
                }
                else if (command.ToLower() == "opponent")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    string direction = tokens[3];

                    if (IndexValidation(beach, row, col))
                    {
                        if (IsCellContainsToken(beach, row, col))
                        {
                            opponentTokens++;
                            beach[row][col] = "-";
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            if (IsMovementPossible(beach, row, col, direction))
                            {
                                switch (direction.ToLower())
                                {
                                    case "up": row--; break;
                                    case "down": row++; break;
                                    case "left": col--; break;
                                    case "right":col++; break;
                                    default:
                                        break;
                                }

                                if (IsCellContainsToken(beach, row, col))
                                {
                                    opponentTokens++;
                                    beach[row][col] = "-";
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            PrintField(beach);

            Console.WriteLine($"Collected tokens: {playerTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");
        }

        public static bool IndexValidation(string[][] field, int row, int col)
        {
            int fieldRows = field.GetLength(0);

            if ((row >= 0 && row < fieldRows)
                &&(col >= 0 && col < field[row].Length))
            {
                return true;
            }

            return false;
        }

        public static bool IsCellContainsToken(string[][] field, int row, int col)
        {
            if (field[row][col] == "T")
            {
                return true;
            }

            return false;
        }

        public static bool IsMovementPossible(string[][] field, int currentRow, int currentCol, string direction)
        {
            if (direction.ToLower() == "up")
            {
                if ((currentRow - 1) >= 0)
                {
                    return true;
                }
            }
            else if (direction.ToLower() == "down")
            {
                if ((currentRow + 1) < field.GetLength(0))
                {
                    return true;
                }
            }
            else if (direction.ToLower() == "left")
            {
                if ((currentCol - 1) >= 0)
                {
                    return true;
                }
            }
            else if (direction.ToLower() == "right")
            {
                if ((currentCol + 1) < field[currentRow].Length)
                {
                    return true;
                }
            }

            return false;
        }

        public static void PrintField(string[][] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(' ', field[i]));
            }
        }
    }
}
