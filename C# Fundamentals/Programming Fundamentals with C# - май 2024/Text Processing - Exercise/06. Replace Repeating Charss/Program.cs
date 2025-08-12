// See https://aka.ms/new-console-template for more information
string input = Console.ReadLine();
string newString = "";

for (int i = 0; i < input.Length-1; i++)
{
    if (input[i] != input[i+1])
    {
        newString += ((char)input[i]).ToString();
    }
    
}

if (newString.Length == 0 || input[input.Length-1] != newString[newString.Length-1])
{
    newString += ((char)input[input.Length-1]).ToString();
}

Console.WriteLine(newString);

