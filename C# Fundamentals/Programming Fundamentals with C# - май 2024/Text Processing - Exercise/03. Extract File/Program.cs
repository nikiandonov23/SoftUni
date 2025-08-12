// See https://aka.ms/new-console-template for more information


List<string> input = Console.ReadLine()
    .Split('\\')
    .ToList();

string finalPart=input[input.Count-1];

string[] tockens=finalPart.Split('.');

Console.WriteLine($"File name: {tockens[0]}");
Console.WriteLine($"File extension: {tockens[1]}");
