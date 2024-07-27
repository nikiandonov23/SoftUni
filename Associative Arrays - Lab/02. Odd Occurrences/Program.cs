// See https://aka.ms/new-console-template for more information



List<string> words = Console.ReadLine()          //Java C# PHP PHP JAVA C java                          //java c# c
    .Split(" ")
    .ToList();


Dictionary<string ,int> input=new Dictionary<string ,int>();



for (int i = 0; i < words.Count; i++)
{
    words[i]=words[i].ToLower();
}

for (int i = 0; i < words.Count; i++)
{

    if (!input.ContainsKey(words[i]))
    {
        input.Add(words[i], 0);
        input[words[i]] += 1;
    }
    else
    {
        input[words[i]] += 1;
    }

}

List<string>oddList=new List<string>();

foreach (var word in input)
{
    if (word.Value%2!=0)
    {
        oddList.Add(word.Key);
    }
}

Console.WriteLine(string.Join(" ",oddList));