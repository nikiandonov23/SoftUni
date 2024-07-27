// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());




string word = "";
string synoym = "";

Dictionary<string,string> dictionary = new Dictionary<string,string>();

for (int i = 0; i < n; i++)
{
    word=Console.ReadLine();
    synoym=Console.ReadLine();

    if (!dictionary.ContainsKey(word))
    {
        dictionary.Add(word,synoym);
    }
    else
    {
        dictionary[word] +=", "+synoym;
    }
}

foreach (var element in dictionary)
{
    Console.WriteLine($"{element.Key} - {element.Value}");
}