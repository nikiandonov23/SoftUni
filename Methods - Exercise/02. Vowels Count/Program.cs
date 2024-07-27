// See https://aka.ms/new-console-template for more information


string word=Console.ReadLine();
Console.WriteLine(method(word));

string method(string input)
{
    int result = 0;

    foreach (char letter in word)
    {
        switch (letter)
        {
            case 'a':
                result += 1;
                break;
            case 'e':
                result += 1;
                break;
            case 'i':
                result += 1;
                break;
            case 'o':
                result += 1;
                break;
            case 'u':
                result += 1;
                break;
            case 'A':
                result += 1;
                break;
            case 'E':
                result += 1;
                break;
            case 'I':
                result += 1;
                break;
            case 'O':
                result += 1;
                break;
            case 'U':
                result += 1;
                break;
        }
    }

    return result.ToString();
}

