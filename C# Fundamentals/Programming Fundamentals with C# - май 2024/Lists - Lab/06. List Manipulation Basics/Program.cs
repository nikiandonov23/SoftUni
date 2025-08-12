// See https://aka.ms/new-console-template for more information
using System.Data;



List<int> input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();


string command = "";

while ((command = Console.ReadLine()) != "end")

{
    string[] tockens = command.Split(" ");

    switch (tockens[0])
    {
        case "Add":
            input.Add(int.Parse(tockens[1]));
            break;
        case"Remove":
            input.Remove(int.Parse(tockens[1]));
                break;
        case "RemoveAt":
            input.RemoveAt(int.Parse(tockens[1]));
            break;
        case "Insert":
            input.Insert(int.Parse(tockens[2]), int.Parse(tockens[1]));
            break;
    }
}
Console.WriteLine(string.Join(" ",input));


