// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());


HashSet<string>allNames=new HashSet<string>();
for (int i = 0; i < n; i++)
{
    string input=Console.ReadLine();

    allNames.Add(input);
}

foreach (var name in allNames)
{
    Console.WriteLine(name);
}