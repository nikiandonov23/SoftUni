// See https://aka.ms/new-console-template for more information

string[] input=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();


Action action = PrintMethod;


void PrintMethod()
{
    foreach (var word in input)
    {
        Console.WriteLine(word);
    }
}

action();