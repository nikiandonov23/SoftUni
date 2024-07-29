using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Pieces> allPieces = new List<Pieces>();

        for (int i = 0; i < n; i++)
        {
            List<string> input = Console.ReadLine().Split("|").ToList();
            Pieces currentPiece = new Pieces
            {
                Piece = input[0],
                Composer = input[1],
                Key = input[2]
            };
            allPieces.Add(currentPiece);
        }

        string command = "";
        while ((command = Console.ReadLine()) != "Stop")
        {
            string[] tokens = command.Split("|");

            switch (tokens[0])
            {
                case "Add":
                    string piece = tokens[1];
                    string composer = tokens[2];
                    string key = tokens[3];

                    if (allPieces.Any(p => p.Piece == piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        Pieces newPiece = new Pieces
                        {
                            Piece = piece,
                            Composer = composer,
                            Key = key
                        };
                        allPieces.Add(newPiece);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    break;

                case "Remove":
                    piece = tokens[1];
                    Pieces pieceToRemove = allPieces.FirstOrDefault(p => p.Piece == piece);

                    if (pieceToRemove != null)
                    {
                        allPieces.Remove(pieceToRemove);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    break;

                case "ChangeKey":
                    piece = tokens[1];
                    string newKey = tokens[2];

                    Pieces pieceToChange = allPieces.FirstOrDefault(p => p.Piece == piece);

                    if (pieceToChange != null)
                    {
                        pieceToChange.Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    break;
            }
        }

        foreach (var element in allPieces)
        {
            Console.WriteLine($"{element.Piece} -> Composer: {element.Composer}, Key: {element.Key}");
        }
    }

    class Pieces
    {
        public string Piece { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}