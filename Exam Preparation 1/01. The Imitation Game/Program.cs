// See https://aka.ms/new-console-template for more information


string input = Console.ReadLine();

string command = "";
while ((command = Console.ReadLine()) != "Decode")
{
    string[] tockens = command.Split("|");

    switch (tockens[0])
    {
        case "Move":
            int numberOfLetters = int.Parse(tockens[1]);

            string toBeMoved = input.Substring(0, numberOfLetters);
            input = input.Remove(0, numberOfLetters);
            input += toBeMoved;
            
            break;

        case "Insert":
            int index=int.Parse(tockens[1]);
            string value = tockens[2];

            input=input.Insert(index , value);
            
            break;


        case "ChangeAll":
            string substracting = tockens[1];
            string replacement = tockens[2];

            while (input.Contains(substracting))
            {
                input = input.Replace(substracting, replacement);
            }
            
            break;
            

    }
}

Console.WriteLine($"The decrypted message is: {input}");