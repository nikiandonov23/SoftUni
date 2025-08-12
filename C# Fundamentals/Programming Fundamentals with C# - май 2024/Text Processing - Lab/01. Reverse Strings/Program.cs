// See https://aka.ms/new-console-template for more information

string input="";

while ((input = Console.ReadLine()) != "end")
{
    string finalWord = "";
    for (int i = input.Length - 1; i >= 0; i--)
    {
        finalWord += input[i];
    }

    Console.Write($"{input} = {finalWord}");
    Console.WriteLine();

    finalWord = "";
}