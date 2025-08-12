// See https://aka.ms/new-console-template for more information


List<int> input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

int currentIndex = int.Parse(Console.ReadLine());
int steps = int.Parse(Console.ReadLine());

currentIndex = (currentIndex + steps) % input.Count;


Console.WriteLine(currentIndex);

