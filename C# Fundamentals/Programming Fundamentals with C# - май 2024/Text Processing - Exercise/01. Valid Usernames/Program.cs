// See https://aka.ms/new-console-template for more information


List<string> input = Console.ReadLine()
    .Split(", ")
    .ToList();

bool isValid = true;

foreach (var word in input)    //vurti dumite
{


    for (int i = 0; i < word.Length; i++)
    {

        if (!char.IsLetterOrDigit(word[i]) && word[i] != '-' && word[i] != '_'||word.Length<3||word.Length>16)
        {
            isValid = false;
            break;
        }
        else
        {
                isValid=true;
        }
    }

    if (isValid)
    {
        Console.WriteLine(word);
    }


}
