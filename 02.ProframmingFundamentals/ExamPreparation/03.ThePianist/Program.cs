using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ThePianist
{
    class Piece
    {
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
        public override string ToString()
        {
            return $"{Name} -> Composer: {Composer}, Key: {Key}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Piece> pieces = new List<Piece>();

            for (int i = 0; i < n; i++)
            {
                string inputPiece = Console.ReadLine();

                string[] tokensPiece = inputPiece
                   .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string pieceName = tokensPiece[0];
                string composer = tokensPiece[1];
                string key = tokensPiece[2];

                if (!pieces.Any(p => p.Name == pieceName))
                {
                    pieces.Add(new Piece
                    {
                        Name = pieceName,
                        Composer = composer,
                        Key = key
                    });
                }
            }

            string inputCommand = Console.ReadLine();

            while (inputCommand != "Stop")
            {
                string[] tokensCommand = inputCommand
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);
                string command = tokensCommand[0];
                string piece = tokensCommand[1];

                if (command == "Add")
                {
                    string composer = tokensCommand[2];
                    string key = tokensCommand[3];

                    if (!pieces.Any(p => p.Name == piece))
                    {
                        pieces.Add(new Piece 
                        {
                            Name = piece,
                            Composer = composer,
                            Key = key
                        });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (command == "Remove")
                {
                    if (pieces.Any(p => p.Name == piece))
                    {
                        Console.WriteLine($"Successfully removed {piece}!");
                        int index = pieces.FindIndex(p => p.Name == piece);
                        pieces.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (command == "ChangeKey")
                {
                    string newKey = tokensCommand[2];

                    if (pieces.Any(p => p.Name == piece))
                    {
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        int index = pieces.FindIndex(p => p.Name == piece);
                        pieces[index].Key = newKey;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                inputCommand = Console.ReadLine();
            }

            pieces = pieces
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Composer)
                .ToList();

            Console.WriteLine(string.Join("\n", pieces.Select(p => p.ToString())));
        }
    }
}
