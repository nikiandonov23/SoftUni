// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"([@#])(?<word1>[a-zA-Z]{3,})\1\1(?<word2>[a-zA-Z]{3,})\1";

List<Worlds> allWorlds = new List<Worlds>();

foreach (Match match in Regex.Matches(input, pattern))
{
    if (match.Success)
    {
        Worlds currentWorld = new Worlds();
        currentWorld.World1 = match.Groups["word1"].Value;
        currentWorld.World2 = match.Groups["word2"].Value;
        allWorlds.Add(currentWorld);
    }
}

if (allWorlds.Count > 0)
{
    Console.WriteLine($"{allWorlds.Count} word pairs found!");

    List<string> finalWorlds = new List<string>();
    foreach (var world in allWorlds)
    {
        char[] reversedArray = world.World2.ToCharArray();
        Array.Reverse(reversedArray);
        string reversedWorld2 = new string(reversedArray);

        if (world.World1 == reversedWorld2)
        {
            string toBeAdded = world.World1 + " <=> " + world.World2;
            finalWorlds.Add(toBeAdded);
        }
    }

    if (finalWorlds.Count > 0)
    {
        Console.WriteLine("The mirror words are:");
        Console.WriteLine(string.Join(", ", finalWorlds));
    }
    else
    {
        Console.WriteLine("No mirror words!");
    }
}
else
{
    Console.WriteLine("No word pairs found!");
    Console.WriteLine("No mirror words!");
}

class Worlds
{
    public string World1 { get; set; }
    public string World2 { get; set; }
}