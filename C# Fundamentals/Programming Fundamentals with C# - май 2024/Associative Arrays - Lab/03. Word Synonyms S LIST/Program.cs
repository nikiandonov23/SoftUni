// See https://aka.ms/new-console-template for more information


int n = int.Parse(Console.ReadLine());




string word = "";
string synoym = "";

Dictionary<string, List<string>> input=new Dictionary<string,List<string>>();

for (int i = 0; i < n; i++)
{
    word = Console.ReadLine();
    synoym = Console.ReadLine();
    if (!input.ContainsKey(word))
    {
        input.Add(word, new List<string> { synoym });
    }
    else
    {
        input[word].Add(synoym);
    }
}

foreach (var element in input)
{
    Console.WriteLine($"{element.Key} - {string.Join(", ", element.Value)}");
}