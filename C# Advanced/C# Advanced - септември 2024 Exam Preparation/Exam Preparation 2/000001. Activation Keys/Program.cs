// See https://aka.ms/new-console-template for more information

using System.Data.SqlTypes;

string input = Console.ReadLine();

string command = "";
while ((command = Console.ReadLine()) != "Generate")
{
    string[] tockens = command.Split(">>>");
    string action = tockens[0];

    switch (action)
    {
        case "Contains":
            string substracting = tockens[1];

            if (input.Contains(substracting))
            {
                Console.WriteLine($"{input} contains {substracting}");
                break;
            }
            else
            {
                Console.WriteLine("Substring not found!");
                break;
            }
            break;


        case "Flip":
            string upperOrLower=tockens[1];
            int startIndex = int.Parse(tockens[2]);
            int endIndex=int.Parse(tockens[3]);

            string toBeChanged = input.Substring(startIndex, endIndex - startIndex);
            if (upperOrLower== "Upper")
            {
                string Upper = toBeChanged.ToUpper();
                input = input.Replace(toBeChanged, Upper);
                Console.WriteLine(input);
            }
            else if (upperOrLower== "Lower")
            {
                string Lower=toBeChanged.ToLower();
                input=input.Replace(toBeChanged, Lower);
                Console.WriteLine(input);
            }
            break;


        case "Slice":
             startIndex=int.Parse(tockens[1]);
             endIndex=int.Parse(tockens[2]);

            input = input.Remove(startIndex, endIndex - startIndex);
            Console.WriteLine(input);


            break;
    }
}

Console.WriteLine($"Your activation key is: {input}");
