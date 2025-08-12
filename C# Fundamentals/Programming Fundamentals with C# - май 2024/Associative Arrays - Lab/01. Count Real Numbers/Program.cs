// See https://aka.ms/new-console-template for more information



List<double> input = Console.ReadLine()
    .Split(" ")
    .Select(double.Parse)
    .ToList();

SortedDictionary<double, int> numberOccurances = new SortedDictionary<double, int>();


for (int i = 0; i < input.Count; i++)
{

    if (!numberOccurances.ContainsKey(input[i]))
    {
        numberOccurances.Add(input[i], 0);
    }

    numberOccurances[input[i]] += 1;

}

foreach (var number in numberOccurances)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}