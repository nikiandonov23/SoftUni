// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

numbers=numbers.OrderByDescending(x=>x)
    .Take(3)
    .ToList();

Console.WriteLine(string.Join(" ",numbers));