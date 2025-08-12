// See https://aka.ms/new-console-template for more information


string input = Console.ReadLine();

string command = "";
while ((command = Console.ReadLine()) != "Done")
{
    string[] tockens = command.Split(" ");

    string action = tockens[0];

    switch (action)
    {
        case "TakeOdd":
            string newInput = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newInput += input[i];
                }

            }
            input = newInput;
            Console.WriteLine(input);
            break;



        case "Cut":
            int index = int.Parse(tockens[1]);
            int lenght = int.Parse(tockens[2]);

            input = input.Remove(index, lenght);
            Console.WriteLine(input);

            break;



        case "Substitute":
            string substracting = tockens[1];
            string substitute = tockens[2];

            if (input.Contains(substracting))
            {
                input=input.Replace(substracting, substitute);
                Console.WriteLine(input);

            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }
            break;
    }
}

Console.WriteLine($"Your password is: {input}");