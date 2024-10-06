// See https://aka.ms/new-console-template for more information
List<int> input=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

input=input.OrderBy(x=>x).Select(x=>x).Where(x=>x%2==0).ToList();

Console.WriteLine(string.Join(", ",input));