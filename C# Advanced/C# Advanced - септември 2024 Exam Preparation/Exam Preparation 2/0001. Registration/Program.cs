// See https://aka.ms/new-console-template for more information


using System.Data.SqlTypes;

string input=Console.ReadLine();

string command = "";
while ((command = Console.ReadLine()) != "Registration")
{
    string[] tockens = command.Split(" ");

    switch (tockens[0])
    {
        case "Letters":
            string upperlower = tockens[1];

            switch (upperlower)
            {
                case "Lower":
                    input = input.ToLower();
                    Console.WriteLine(input);
                    break;

                case "Upper":
                    input = input.ToUpper();
                    Console.WriteLine(input);
                    break;
            }
            break;


        case "Reverse":
            int startIndex=int.Parse(tockens[1]);
            int endIndex=int.Parse(tockens[2]);

            if (startIndex >= 0 && endIndex < input.Length && startIndex <= endIndex) // Index validation
            {
                string reversed = input.Substring(startIndex, endIndex - startIndex + 1);

                char[] nqkvaduma = reversed.ToCharArray();
                Array.Reverse(nqkvaduma);
                string oburnataDuma = new string(nqkvaduma);
                Console.WriteLine(oburnataDuma);
            }
            
          
            break;


        case "Substring":
            string substracting = tockens[1];
            if (input.Contains(substracting))
            {
                int index = input.IndexOf(substracting);
                input = input.Remove(index, substracting.Length);
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine($"The username {input} doesn't contain {substracting}.");
            }

            break;




        case "Replace":
            string replace=tockens[1];
            input = input.Replace(replace, "-");
            Console.WriteLine(input);
            break;


        case "IsValid":
            string character=tockens[1];
            if (input.Contains(character))
            {
                Console.WriteLine($"Valid username.");
            }
            else
            {
                Console.WriteLine($"{character} must be contained in your username.");
            }
            break;
    }
}