// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

List<int> input=Console.ReadLine().Split(", ").Select(int.Parse).ToList();

Console.WriteLine(input.Count);
Console.WriteLine(input.Sum());
