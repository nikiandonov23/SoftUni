// See https://aka.ms/new-console-template for more information



List<double> input = Console.ReadLine()
    .Split(" ")
    .Select(double.Parse)
    .ToList();



List<double> newList = new List<double>();
int rightCount = input.Count - 1;

for (int i = 0; i < input.Count / 2; i++)
{

    newList.Add(input[i] + input[input.Count - 1 - i]);



}

if (input.Count % 2 != 0)
{
    newList.Add(input[(input.Count - 1) / 2]);
}

Console.WriteLine(string.Join(" ", newList));