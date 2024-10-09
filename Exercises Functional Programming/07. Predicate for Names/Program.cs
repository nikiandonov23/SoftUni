// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


Func<string, bool> lenghtChecker = x => x.Length <= n;
names= names.Where(lenghtChecker).ToArray();

foreach (var name in names)
{
    Console.WriteLine(name);
}