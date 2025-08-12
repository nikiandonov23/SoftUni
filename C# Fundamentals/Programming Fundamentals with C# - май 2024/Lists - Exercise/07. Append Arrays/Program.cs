List<string> input = Console.ReadLine()
    .Split("|")
    .Reverse()
    .ToList();

string inputString = String.Join("|", input);
string newString = "";                                           //78456123

for (int i = 0; i < inputString.Length; i++)
{
    if (inputString[i] != ' ')
    {
        newString += inputString[i];
    }
}

string newString2 = "";

for (int i = 0; i < newString.Length; i++)
{


    if (newString[i] != '|')
    {
        newString2 += newString[i]+" ";
    }

}

string final=newString2.TrimEnd().TrimStart();
string[] array=final.Split(" ");
Console.Write(string.Join(" ",array));


