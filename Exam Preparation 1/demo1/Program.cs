// See https://aka.ms/new-console-template for more information

string input=Console.ReadLine();

string command = "";
while ((command = Console.ReadLine()) != "Abracadabra")
{
    string[] tockens = command.Split(" ");
    string action = tockens[0];

    switch (action)
    {
        case "Abjuration":
            input = input.ToUpper();
            Console.WriteLine(input);
            break;


        case "Necromancy":
            input = input.ToLower();
            Console.WriteLine(input);
            break;


        case "Illusion":
            int index=int.Parse(tockens[1]);
            char letter=char.Parse(tockens[2]);

            if (index >= 0 && index < input.Length ) // Proverqvam dali indexa e validen
            {
                char[] charArray = input.ToCharArray();

                
                charArray[index] = letter;

                string modifiedInput = new string(charArray);
                input=modifiedInput;
                Console.WriteLine("Done!");
            }
            else
            {
                Console.WriteLine("The spell was too weak.");
            }
            break;


        case "Divination":
            string firstSubstring = tockens[1];
            string secondSubstring = tockens[2];
            if (input.Contains(firstSubstring))
            {
                input = input.Replace(firstSubstring, secondSubstring);
                Console.WriteLine(input);
            }
            else
            {
                continue;
            }
            break;


        case "Alteration":
            string substring=tockens[1];
            if (input.Contains(substring))
            {
                input=input.Replace(substring, "");
                Console.WriteLine(input);
            }
            else
            {
                continue;
            }
            break;
        default:
            Console.WriteLine("The spell did not work!");
            break;
    }
}
