// See https://aka.ms/new-console-template for more information


string[] input = Console.ReadLine()
    .Split(" ")
    .ToArray();

List<int> word1 = new List<int>();
List<int> word2 = new List<int>();

int sum = 0;



string word11 = input[0];
string word22 = input[1];

for (int i = 0; i < word11.Length; i++)
{
    word1.Add((int)(word11[i])); 
}

for (int j = 0; j < word22.Length; j++)
{
   word2.Add((int)(word22[j]));
}

if (word1.Count<word2.Count)    //vurti do po malkiq list
{

    for (int i = 0; i < word1.Count; i++)
    {
        sum += (word1[i] * word2[i]);

       
    }
    for (int j = word1.Count; j < word2.Count; j++)
    {
        sum += word2[j];
    }
}
else
{
    for (int i = 0; i < word2.Count; i++)
    {
        sum += (word1[i] * word2[i]);

    }

    for (int i = word2.Count; i < word1.Count; i++)
    {
        sum += word1[i];
    }

}

Console.WriteLine(sum);

