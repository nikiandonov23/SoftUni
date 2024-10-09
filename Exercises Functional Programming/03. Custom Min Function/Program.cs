// See https://aka.ms/new-console-template for more information

string[] input=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

Action<string> action= x=>Console.WriteLine(x);

foreach (var word in input)
{
    action(word);
}