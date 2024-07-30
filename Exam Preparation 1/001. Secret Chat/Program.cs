// See https://aka.ms/new-console-template for more information
string input = Console.ReadLine();

string command = "";
while ((command = Console.ReadLine()) != "Reveal")
{
    string[] tockens = command.Split(":|:");

    string action = tockens[0];

    switch (action)
    {
        case "InsertSpace":
            int index = int.Parse(tockens[1]);
            input = input.Insert(index, " ");
            Console.WriteLine(input);

            break;


        case "Reverse":
            string substracting= tockens[1];

            if (input.Contains(substracting))
            {
                int startIndex = input.IndexOf(substracting);
                int endIndex = startIndex + substracting.Length;

                input=input.Remove(startIndex, endIndex-startIndex);


                char[] nqkvaduma = substracting.ToCharArray();
                Array.Reverse(nqkvaduma);
                string reversedSubstracting = new string(nqkvaduma);

                input += reversedSubstracting;
                Console.WriteLine(input);


            }
            else
            {
                Console.WriteLine("error");
            }
            break;


        case "ChangeAll":

            substracting=tockens[1];
            string replacement= tockens[2];

            input = input.Replace(substracting, replacement);
            Console.WriteLine(input);
            break;
    }
}

Console.WriteLine($"You have a new text message: {input}");