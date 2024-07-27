using System;

class hello
{
    static void Main()
    {

        string text = Console.ReadLine();

        int textDigit = text.Length;
        for (int i = 0; i <= textDigit; i++)
        {
            char letter = text[i];
            Console.WriteLine(letter);
        }

    }
}
