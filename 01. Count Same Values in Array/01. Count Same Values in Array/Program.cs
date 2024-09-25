// See https://aka.ms/new-console-template for more information




List<double>numbers =Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

Dictionary<double,int>numberOccurances=new Dictionary<double,int>();

foreach (var number in numbers)
{
    if (numberOccurances.ContainsKey(number))
    {
        numberOccurances[number] += 1;
    } 
    else if (!numberOccurances.ContainsKey(number))
    {
        numberOccurances.Add(number,1);
    }
}

foreach (var number in numberOccurances)
{
    Console.WriteLine($"{number.Key} - {number.Value} times");
}