// See https://aka.ms/new-console-template for more information


List<int> input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

for (int i = 0; i < input.Count; i++)
{
    if (input[i] < 0)
    {
        input.RemoveAt(i);
        i -= 1;
    }
    if (input.Count <= 0)
    {
        Console.WriteLine("empty");
        break;
    }
}

for (int i = input.Count-1; i >= 0; i--)
{
    Console.Write(input[i]+" ");
}




