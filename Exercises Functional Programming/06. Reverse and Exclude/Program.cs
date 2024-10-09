// See https://aka.ms/new-console-template for more information

int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());

Func<int, bool> filtering = x => x % n != 0;
Console.WriteLine(string.Join(" ", input.Where(filtering).Reverse()));

