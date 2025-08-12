// See https://aka.ms/new-console-template for more information


void method()
{

    string input = "";
    while ((input = Console.ReadLine()) != "END")
    {
        string newString = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            newString += input[i];
        }

        if (newString == input)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }



