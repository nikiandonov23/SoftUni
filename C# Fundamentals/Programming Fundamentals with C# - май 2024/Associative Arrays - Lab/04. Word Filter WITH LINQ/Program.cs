// See https://aka.ms/new-console-template for more information


string[] input = Console.ReadLine()
    .Split(" ")
    .Where(x=>x.Length%2==0)
    .ToArray();



Console.WriteLine(string.Join(" ",input));