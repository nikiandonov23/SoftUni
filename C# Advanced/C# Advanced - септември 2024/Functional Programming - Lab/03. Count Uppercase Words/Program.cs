// See https://aka.ms/new-console-template for more information
List<string> input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

Func<string,bool>isUpper=input=>char.IsUpper(input[0]);

input=input.Where(isUpper).ToList();
foreach (var word in input)
{
    Console.WriteLine(word);
}