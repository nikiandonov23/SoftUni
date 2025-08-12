// See https://aka.ms/new-console-template for more information

string[] input=Console.ReadLine()
    .Split(" ")
    .ToArray();

List<string>onlyEvenWords=new List<string>();

for (int i = 0; i < input.Length; i++)
{
    string word=input[i];
    if (word.Length%2==0)
    {
        onlyEvenWords.Add(word);

    }

}

foreach (var word in onlyEvenWords)
{
    Console.WriteLine(word);
}