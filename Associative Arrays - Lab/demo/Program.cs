// See https://aka.ms/new-console-template for more information


List<double> numbers = Console.ReadLine()    //   8 2 2 8 2
    .Split(" ")
    .Select(double.Parse)
    .ToList();

SortedDictionary<double,int> numberCounts= new SortedDictionary<double, int>();

for (int i = 0; i < numbers.Count; i++)
{
    double key=numbers[i];
    int value=0;

    if (!numberCounts.ContainsKey(key))
    {
        numberCounts.Add(key, value);
    }

    value++;
    numberCounts[key] += value;

}
foreach (var number in numberCounts)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}