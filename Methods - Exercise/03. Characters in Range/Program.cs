// See https://aka.ms/new-console-template for more information



char input1 = char.Parse(Console.ReadLine());
char input2 = char.Parse(Console.ReadLine());



Console.WriteLine(method(input1,input2));


string method(char n1,char n2)
{
    int char1Value = input1;
    int char2Value = input2;

    string result = "";

    if (char1Value < char2Value)
    {

        for (int i = char1Value; i < char2Value - 1; i++)
        {
            char nextLetter = (char)(input1 + 1);
            input1 = nextLetter;
            result+=(nextLetter + " ");
        }

    }

    if (char1Value > char2Value)
    {


        for (int i = char2Value; i < char1Value - 1; i++)
        {
            char nextLetter = (char)(input2 + 1);
            input2 = nextLetter;
            result += (nextLetter + " ");
        }
    }
    return result;
}



