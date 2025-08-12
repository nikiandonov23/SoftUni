// See https://aka.ms/new-console-template for more information


string[] input = Console.ReadLine()
    .Split(" ")
    .ToArray();

foreach (var word in input)      //hi abc add
{
    for (int i = 0; i < word.Length; i++)     // 2 3 3
    {
        Console.Write(word);
    }
}
