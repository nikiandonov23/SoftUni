// See https://aka.ms/new-console-template for more information



List<double> inputNumbers = Console.ReadLine()
    .Split(" ")
    .Select(double.Parse)
    .ToList();

for (int i = 0; i < inputNumbers.Count - 1; i++)
{

    if (inputNumbers[i] == inputNumbers[i + 1])
    {
        inputNumbers[i] += inputNumbers[i + 1];
        inputNumbers.RemoveAt(i + 1);
        i = -1;
    }

}

Console.WriteLine(string.Join(" ", inputNumbers));