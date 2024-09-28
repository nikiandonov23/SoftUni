// See https://aka.ms/new-console-template for more information


int n = int.Parse(Console.ReadLine());


HashSet<string> allElements=new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string[] input=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
    foreach (var element in input)
    {
        if (!allElements.Contains(element))
        {
            allElements.Add(element);
        }
    }
}
allElements = allElements.OrderBy(x => x).ToHashSet();
Console.WriteLine(string.Join(" ",allElements));