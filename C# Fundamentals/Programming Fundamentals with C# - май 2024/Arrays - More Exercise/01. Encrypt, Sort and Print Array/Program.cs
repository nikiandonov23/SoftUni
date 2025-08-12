// See https://aka.ms/new-console-template for more information


int n = int.Parse(Console.ReadLine());

string[] input = new string[n];

int[] value=new int[n];
List<char> voweChars = new List<char>(){'a','e','i','o','u','A','E','I','O','U',};       // Y ne e glasna !!! pfff

for (int i = 0; i <= input.Length-1; i++)
{
    string word = Console.ReadLine();
    input[i] = word;

    for (int j = 0; j <= word.Length-1; j++)
    {
        char letter = word[j];
        int letterValue = Convert.ToInt32(letter);


        if (voweChars.Contains(letter))
        {
            value[i] += letterValue*word.Length;
        }
        else
        {
            value[i] += letterValue / word.Length;
        }
        



    }
}

List<int> finalValue = value.ToList();

finalValue.Sort();
for (int i = 0; i < finalValue.Count; i++)
{
    Console.WriteLine(finalValue[i]);
}






