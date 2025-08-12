// See https://aka.ms/new-console-template for more information


List<string> input=Console.ReadLine()                                     // A12b s17G
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();
double finalSum = 0;
foreach (var str in input)
{
    char letterBefore = str[0];
    char letterAfter = str[str.Length-1];
    double number = int.Parse(str.Substring(1, str.Length - 2));

    if (char.IsUpper(letterBefore))
    {
        number /= numberInTheAlphabet(letterBefore);
    }
    else if (char.IsLower(letterBefore))
    {
        number*= numberInTheAlphabet(letterBefore);
    }

    if (char.IsUpper(letterAfter))
    {
        number -= numberInTheAlphabet(letterAfter);
    }
    else if (char.IsLower(letterAfter))
    {
        number += numberInTheAlphabet(letterAfter);
    }

    finalSum += number;




}

Console.WriteLine($"{finalSum:F2}");


static int numberInTheAlphabet(char letter)
{
    if (char.IsUpper(letter))
    {
        return letter - 'A' + 1;
    }


    else
    {
        return letter - 'a' + 1;
    }


}