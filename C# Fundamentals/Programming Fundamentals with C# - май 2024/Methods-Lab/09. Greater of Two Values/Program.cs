// See https://aka.ms/new-console-template for more information


string input = Console.ReadLine();

if (input == "string")
{
    string inputAsString1 = Console.ReadLine();
    string inputAsString2 = Console.ReadLine();
    Console.WriteLine(getMaxString(inputAsString1, inputAsString2));

}
if (input == "char")
{
    char inputAsChar1 = char.Parse(Console.ReadLine());
    char inputAsChar2 = char.Parse(Console.ReadLine());
    Console.WriteLine(getMaxChar(inputAsChar1, inputAsChar2));
}
if (input == "int")
{
    int inputAsInt1 = int.Parse(Console.ReadLine());
    int inputAsInt2 = int.Parse(Console.ReadLine());
    Console.WriteLine(getMaxInt(inputAsInt1, inputAsInt2));

}

static string getMaxString(string first, string second)
{
    if (string.Compare(first, second) > 0)
    {
        return first;

    }
    else
    {
        return second;
    }

}

static char getMaxChar(char first, char second)
{
    if (first > second)
    {
        return first;
    }
    else
    {
        return second;
    }
}

static int getMaxInt(int first, int second)
{
    if (first > second)
    {
        return first;
    }
    else
    {
        return second;
    }
}