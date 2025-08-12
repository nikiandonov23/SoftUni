// See https://aka.ms/new-console-template for more information


string[] banWords=Console.ReadLine()     // Linux, Windows
    .Split(", ")
    .ToArray();

string input = Console.ReadLine();


for (int i = 0; i < banWords.Length; i++)      //vurti 2 puti
{

    string tocken = banWords[i];
    string censored = "";
    for (int j = 0; j < tocken.Length; j++)
    {
        censored +="*";
    }


    int index = 0;
    while (index != -1)
    {
        index = input.IndexOf(tocken);
        if (index==-1)
        {
            break;
        }

        input = input.Replace(tocken, censored);
    }

 


}

Console.WriteLine(input);



