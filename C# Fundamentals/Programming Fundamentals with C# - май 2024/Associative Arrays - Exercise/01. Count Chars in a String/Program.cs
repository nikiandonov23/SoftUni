// See https://aka.ms/new-console-template for more information



string input=Console.ReadLine();

Dictionary<char,int> CharOccurances=new Dictionary<char,int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i]==' ')
    {
        continue;
    }
    if (!CharOccurances.ContainsKey(input[i]))    //ako v re4nika nqma key char
    {
        CharOccurances.Add(input[i], 0);
        CharOccurances[input[i]]++;
    }
    else
    {
        CharOccurances[input[i]]++;
    }

}

foreach (var element in CharOccurances)
{
    Console.WriteLine($"{element.Key} -> {element.Value}");
}