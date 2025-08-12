// See https://aka.ms/new-console-template for more information


string input = Console.ReadLine();    //    abv>1>1>2>2asdasd
int explosion = 0;
for (int i = 0; i < input.Length; i++)
{
    

    if (char.IsDigit(input[i]))
    {
        explosion += input[i] -'0';
        if (explosion>0)
        {
            input=input.Remove(i,1);
            explosion--;
        }

        i--;
        continue;

    }

    if (char.IsLetter(input[i])&&explosion>0)
    {
        input=input.Remove(i,1);

        explosion--;
        i--;
        continue;
    }


 
    

}

Console.WriteLine(input);

